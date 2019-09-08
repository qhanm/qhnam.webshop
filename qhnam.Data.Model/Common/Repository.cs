using Microsoft.EntityFrameworkCore;
using qhn.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace qhnam.Data.Model.Common
{
    public class Repository<T, K> : IRepository<T, K>, IDisposable where T : EntityId<K>
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public IQueryable<T> FindAll(params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if (includeProperties != null)
            {
                foreach (var include in includeProperties)
                {
                    items = items.Include(include);
                }
            }

            return items;
        }

        public IQueryable<T> FindAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if (includeProperties != null)
            {
                foreach (var include in includeProperties)
                {
                    items = items.Include(include);
                }
            }

            return items.Where(predicate);
        }

        public T FindById(K id, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id.Equals(id));
        }

        public T FindSingle(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(predicate);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Remove(K id)
        {
            var entity = FindById(id);
            Remove(entity);
        }

        public void RemoveMulti(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}