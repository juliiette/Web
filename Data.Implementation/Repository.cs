using System;
using System.Collections.Generic;
using System.Linq;
using Data.Abstract;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly OfficeContext _context;
        private  DbSet<TEntity> _dbSet;

        public Repository(OfficeContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();

        }


        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _dbSet.Update(item);
            _context.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            if (item != null)
            {
                _dbSet.Remove(item);
                _context.SaveChanges();
            }
        }


        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}