using System.Collections.Generic;

namespace MyFirstApp.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void BeginTransaction();
        void Commit();

        void Add(TEntity entity);
        TEntity GetById(long id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);           
    }
}