using Internship.Domain.Entity;

namespace Internship.DAL.Interfaces
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetListAsync();
        Photo GetID(Guid id);
        void Update(Photo photo);
    }
}
