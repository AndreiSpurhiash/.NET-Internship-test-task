using AutoMapper;
using Internship.Contracts.Entity;
using Internship.DAL.Interfaces;
using Internship.DAL.Repositories;
using Internship.Domain.Entity;
using Internship.Service.Entity;
using Internship.Service.Interfaces;

namespace Internship.Service.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly IMapper _mapper;
        private readonly BaseRepository<Photo> _photoRepository;

        public PhotoService(IMapper mapper, BaseRepository<Photo> photoRepository)
        {
            _mapper = mapper;
            _photoRepository = photoRepository;
        }

        public async Task<IEnumerable<PhotoModel>> GetListAsync()
        {
            var photos = await _photoRepository.GetListAsync().ConfigureAwait(false);
            return _mapper.Map<IEnumerable<PhotoModel>>(photos);
        }
        public async Task<PhotoModel> GetPhotoByIDAsync(Guid id)
        {
            var photo = await _photoRepository.GetAsync(id).ConfigureAwait(false);
            return _mapper.Map<PhotoModel>(photo);
        }
    }
}
