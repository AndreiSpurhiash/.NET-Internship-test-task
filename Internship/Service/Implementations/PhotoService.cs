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

namespace Internship.Service.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly IMapper _mapper;
        private readonly IPhotoRepository _photoRepository;

        public PhotoService(IMapper mapper, IPhotoRepository photoRepository)
        {
            _mapper = mapper;
            _photoRepository = photoRepository;
        }

        public async Task CreateCVSAsync()
        {
            var photos = await _photoRepository.GetListAsync().ConfigureAwait(false);

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

        public async Task<IEnumerable<PhotoModel>> GetListAsync()
        {
            var photos = await _photoRepository.GetListAsync().ConfigureAwait(false);
            return _mapper.Map<IEnumerable<PhotoModel>>(photos);
        }
        public async Task<PhotoModel> GetPhotoByIDAsync(Guid id)
        {
            var photo = await _photoRepository.GetPhotoByIdAsync(id).ConfigureAwait(false);
            return _mapper.Map<PhotoModel>(photo);
        }

        public async Task Update(PhotoModel photoModel)
        {
            var photo = _mapper.Map<Photo>(photoModel);
            await _photoRepository.Update(photo).ConfigureAwait(false);
        }
    }
}
