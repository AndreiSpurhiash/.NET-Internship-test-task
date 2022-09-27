using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class AuthorRepository : BaseRepository<Author>
    {
        readonly DbContext db;
        public AuthorRepository(DbContext context) : base(context)
        {
            db = context;
        }
    }
}
