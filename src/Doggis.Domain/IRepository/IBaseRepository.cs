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

        Task AddRange(IEnumerable<TEntity> entities);

        Task Update(TEntity entity);

        Task Delete(object id);

        Task<TEntity> Get(object id);

        Task<IEnumerable<TEntity>> GetAll();

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    }
}