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

        public  void CreateCVS()
        {
            var photoss = _photoRepository.GetListAsync().ConfigureAwait(false);

            string path = @"C:\Users\andre\source\repos\AndreiSpurhiash\.NET-Internship-test-task\Internship\photosCSV.csv";
          
            using (var photosCSV = new StreamWriter(path, false, Encoding.GetEncoding("utf-16")))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("en-US"));
                {
                    csvConfig.HasHeaderRecord = true;
                    csvConfig.Delimiter = " ";
                };

                using (var csv = new CsvWriter(photosCSV, csvConfig))
                {
                    csv.WriteRecords( _mapper.Map<IEnumerable<PhotoModel>>(photoss));
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
    }
}
