using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyFirstApp.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        //void BeginTransaction();
        int Commit();

        void Dispose();

        void Add(TEntity entity);
        TEntity GetById(long id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(long id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}