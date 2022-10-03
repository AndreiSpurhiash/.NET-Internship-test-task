using Internship.Contracts.Entity;
using Internship.DAL.Interfaces;
using Internship.Domain.Entity;
using Internship.Exceptions;
using Internship.Migrations;
using Internship.Resources;
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
            return await db.Set<Photo>().Include(av => av.Author).ToListAsync().ConfigureAwait(false);
        }

        public async Task AddRaitingPhotoAsync(Guid id, int rating)
        {
            var photo = await db.Set<Photo>().FindAsync(id).ConfigureAwait(false);
            photo.NumberOfRaiting = photo.NumberOfRaiting + 1;
            photo.AmountOfRaiting = photo.AmountOfRaiting + rating;
            db.Set<Photo>().Update(photo);
            base.Save();
        }
    }
}
