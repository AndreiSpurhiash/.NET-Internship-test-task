using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        readonly DbContext db;
        public AuthorRepository(DbContext context) : base(context)
        {
            db = context;
        }

        public IEnumerable<string> GetEntitiesList()
        {
            return db.Model.GetEntityTypes().Select(c => c.ClrType).Select(x => x.Name).ToList();
        }
    }
}
