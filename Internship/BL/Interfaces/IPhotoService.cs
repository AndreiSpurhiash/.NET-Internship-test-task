using Internship.Contracts.Entity;
using Internship.Domain.Entity;
using Internship.Service.Entity;
using System.Data;

namespace Internship.Service.Interfaces
{
    public interface IPhotoService
    {
        public Task<IEnumerable<PhotoModel>> GetListAsync();
        Task<PhotoModel> GetPhotoByIDAsync(Guid id);
        Task CreateCVSAsync();
        Task Update(IPhoto photoModel);
        Task AddRaitingPhotoAsync(Guid id, int rating);
    }
}
