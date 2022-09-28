using Internship.Service.Entity;

namespace Internship.Service.Interfaces
{
    public interface IAuthorService
    {
        public Task<IEnumerable<Author>> GetListAsync();
    }
}
