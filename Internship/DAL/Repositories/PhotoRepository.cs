using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>
    {
        readonly DbContext db;
        public PhotoRepository(DbContext context) : base(context)
        {
            db = context;
        }
    }
}
