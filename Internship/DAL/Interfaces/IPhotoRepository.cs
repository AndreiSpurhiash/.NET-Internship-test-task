using Internship.Domain.Entity;
using Internship.Migrations;
using System.Data;

namespace Internship.DAL.Interfaces
{
    public interface IPhotoRepository : IBaseRepository<Photo>
    {
        Task<Photo> GetPhotoByIdAsync(Guid id);
        Task<IEnumerable<Photo>> GetListAsync();
        Task AddRaitingPhotoAsync(Guid id, int rating);
    }
}
