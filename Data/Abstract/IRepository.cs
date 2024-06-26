﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IRepository<T> where T : BaseModel
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAllDeleted();
        IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> predicate);

        T GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Remove(Guid id);
        void RemoveRange(IEnumerable<T> entities);
        void AddRange(IEnumerable<T> entities);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);


    }
}
