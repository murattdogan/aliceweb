using Alice.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Alice.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly LuxuryContext dbContext;
        private bool _disposed = false;
        public Repository(LuxuryContext _dbContext)
        {
            this.dbContext = _dbContext;
            this.Table = dbContext.Set<T>();
        }
        public DbSet<T> Table { get; set; }

        public bool Add(T entity)
        {
            Table.Add(entity);
            return Save();
        }

        public bool Update(T entity)
        {
            Table.Update(entity);
            return Save();
        }

        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return Save();
        }

        public IQueryable<T> All()
        {
            return Table.AsNoTracking();
        }

        public IQueryable<T> AllTake(int take)
        {
            return Table.AsNoTracking().Take(take);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return Table.AsNoTracking().Where(where);
        }

        public T First(Expression<Func<T, bool>> where)
        {
            return Table.AsNoTracking().First(where);
        }

        public IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            if (isDesc)
                return Table.OrderByDescending(orderBy);
            return Table.OrderBy(orderBy);
        }

        private bool Save()
        {
            try
            {
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                // TODO: Log Exceptions
                return false;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
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
