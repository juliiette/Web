using System;
using System.Collections.Generic;
using Data.Entities;

namespace Data.Abstract
{
    public interface IGenericRepository<TEntity> : IDisposable
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Create(TEntity entity);
        
        void Update(TEntity entity);

        void Delete(int id);
    }
}