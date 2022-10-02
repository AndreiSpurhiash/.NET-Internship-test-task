namespace Internship.DAL.Interfaces
{
    public interface IBaseRepository<TEntity> 
        where TEntity : class
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        void Delete(TEntity entity);
        Task Save();
    }
}
