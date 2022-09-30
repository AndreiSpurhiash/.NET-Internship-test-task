using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Internship.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Internship.DAL.Repositories
{
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        readonly DbContext db;
        public PhotoRepository(DbContext context) : base(context)
        {
            db = context;
        }

        public async Task<Photo> GetPhotoByIdAsync(Guid id)
        {
            return await db.Set<Photo>().FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<Photo>> GetListAsync()
        {
            return await db.Set<Photo>().ToListAsync().ConfigureAwait(false);
        }
    }
}
