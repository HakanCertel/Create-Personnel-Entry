using Microsoft.EntityFrameworkCore;
using PersonnelApp.Dal.Abstract.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PersonnelApp.Dal.Concrete.BaseRepository
{
    public class Repository<T,TContext> : IBaseRepository<T> 
        where T : class ,new()
        where TContext : DbContext, new()
    {
        private DbSet<T> _dbSet;
        
        public void Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public TResult GetEntity<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            using (var context = new TContext())
            {
                _dbSet = context.Set<T>();
                return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();

            }
        }

        public T GetEntity(Expression<Func<T, bool>> filter)
        {
            using(var context = new TContext())
            {
                _dbSet = context.Set<T>();
                return filter == null ? _dbSet.FirstOrDefault() : _dbSet.Where(filter).FirstOrDefault();

            }
        }

        public virtual List<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            using (var context = new TContext())
            {
                _dbSet = context.Set<T>();
                return filter == null ? _dbSet.Select(selector).ToList() : _dbSet.Where(filter).Select(selector).ToList();
            }
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                _dbSet = context.Set<T>();
                return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

       
    }
}
