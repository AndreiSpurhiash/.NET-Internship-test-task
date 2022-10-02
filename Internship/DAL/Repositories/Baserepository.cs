using Internship.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Internship.DAL.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
       where TEntity : class
    {
        readonly DbContext db;
        public BaseRepository(DbContext context)
        {
            db = context;
        }
        public async Task Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public async Task Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public async Task Save()
        {
            db.SaveChanges();
        }
    }
}
