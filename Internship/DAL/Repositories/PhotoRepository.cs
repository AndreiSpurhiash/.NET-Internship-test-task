using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        readonly DbContext db;
        public PhotoRepository(DbContext context)
        {
            db = context;
        }
        public Photo GetID(Guid id)
        {
            return db.Set<Photo>().Find(id);
        }

        public virtual async Task<IEnumerable<Photo>> GetListAsync()
        {
            return await db.Set<Photo>().ToListAsync().ConfigureAwait(false);
        }

        public void Update(Photo photo)
        {
            db.Entry(photo).State = EntityState.Modified;
        }
    }
}
