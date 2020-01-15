using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new ()
    {
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        void Delete(T entity);
        void Update(T entity);
        void Add(T entity);
    }
}
