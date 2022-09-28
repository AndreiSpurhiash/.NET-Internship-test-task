namespace Internship.DAL.Interfaces
{
    interface IBaseRepository<TEntity> 
        where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
