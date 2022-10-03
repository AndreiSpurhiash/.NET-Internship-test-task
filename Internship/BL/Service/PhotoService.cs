using AutoMapper;
using CsvHelper.Configuration;
using CsvHelper;
using Internship.Contracts.Entity;
using Internship.DAL.Interfaces;
using Internship.DAL.Repositories;
using Internship.Domain.Entity;
using Internship.Service.Entity;
using Internship.Service.Interfaces;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Internship.Exceptions;
using Internship.Resources;

namespace Internship.Service.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly IMapper _mapper;
        private readonly IPhotoRepository _photoRepository;
        private readonly ILogger _logger;

        public PhotoService(IMapper mapper, IPhotoRepository photoRepository, ILogger logger)
        {
            _mapper = mapper;
            _photoRepository = photoRepository;
            _logger = logger;
        }

        public async Task CreateCVSAsync()
        {
            var photos = await _photoRepository.GetListAsync().ConfigureAwait(false);
           
            if (!photos.Any())
            {
                throw new NotFoundException(Localization.PhotoListEmpty);
            }

            try
            {
                string path = Environment.CurrentDirectory + @"\photos.csv";
                using (var photosCSV = new StreamWriter(path, false, Encoding.GetEncoding("utf-8")))
                {
                    using (var csv = new CsvWriter(photosCSV, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "\t" }))
                    {
                        var photosModels = _mapper.Map<IEnumerable<PhotoModel>>(photos);
                        csv.WriteRecords(photosModels);
                    }
                }
            }
            catch (Exception ex)
            {
                new BadRequestException(Localization.CsvWriterError);
            }
        }

        public async Task<IEnumerable<PhotoModel>> GetListAsync()
        {
            var photos = await _photoRepository.GetListAsync().ConfigureAwait(false);
            if (!photos.Any())
            {
                throw new NotFoundException(Localization.PhotoListEmpty);
            }
            return _mapper.Map<IEnumerable<PhotoModel>>(photos);
        }
        public async Task<PhotoModel> GetPhotoByIDAsync(Guid id)
        {
            var photo = await _photoRepository.GetPhotoByIdAsync(id).ConfigureAwait(false);
            if (photo == null)
            {
                throw new NotFoundException(Localization.PhotoNotFound);
            }
            return _mapper.Map<PhotoModel>(photo);
        }

        public async Task Update(IPhoto photoModel)
        {
            var photo = _mapper.Map<Photo>(photoModel);
            await _photoRepository.Update(photo).ConfigureAwait(false);
            await _photoRepository.Save().ConfigureAwait(false);
        }

        public async Task AddRaitingPhotoAsync(Guid id, int rating)
        {
            if (rating > 5 || rating < 1)
            {
                throw new NotFoundException(Localization.NotCorrectRating);
            }
            await _photoRepository.AddRaitingPhotoAsync(id, rating).ConfigureAwait(false);
        }
    }
}
