﻿namespace Base_Backend.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity FindById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(int id, TEntity obj);
        void Delete(int id);
    }
}
