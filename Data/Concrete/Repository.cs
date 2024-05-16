using Data.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{

    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public virtual IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public virtual IQueryable<T> GetAllDeleted()
        {
            return dbSet;
        }

        public T GetById(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return dbSet.AsNoTracking().FirstOrDefault(filter);
        }

        public void Remove(Guid id)
        {
            T entity = GetById(id);
            if (entity != null)
                dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}