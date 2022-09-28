using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface IPhotoService
    {
        public Task<IEnumerable<Photo>> GetListAsync();
        Photo GetID(Guid id);
    }
}
