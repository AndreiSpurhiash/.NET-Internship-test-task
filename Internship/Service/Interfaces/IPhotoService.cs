using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface IPhotoService
    {
        public Task<IEnumerable<PhotoModel>> GetListAsync();
        Task<PhotoModel> GetPhotoByIDAsync(Guid id);
    }
}
