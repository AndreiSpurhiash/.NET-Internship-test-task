using Internship.Domain.Entity;

namespace Internship.DAL.Interfaces
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        public IEnumerable<string> GetEntitiesList();
    }
}
