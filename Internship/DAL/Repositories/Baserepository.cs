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
        public void Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
