namespace Internship.DAL.Interfaces
{
    interface IBaseRepository<TEntity> 
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetListAsync();
        TEntity GetID(Guid id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
