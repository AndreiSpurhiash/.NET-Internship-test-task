using Internship.Domain.Entity;

namespace Internship.DAL.Interfaces
{
    public interface ITextRepository : IBaseRepository<Text>
    {
        Task<IEnumerable<Text>> GetListAsync();
    }
}
