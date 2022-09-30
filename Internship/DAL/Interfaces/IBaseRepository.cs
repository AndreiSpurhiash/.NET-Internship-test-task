﻿namespace Internship.DAL.Interfaces
{
    public interface IBaseRepository<TEntity> 
        where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
