using Doggis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Doggis.Domain.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : EntityBase
    {
        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(Guid id);

        Task<TEntity> Get(Guid id);

        Task<IEnumerable<TEntity>> GetAll();

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    }
}