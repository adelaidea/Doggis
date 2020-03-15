using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DoggisContext _dbContext;

        public BaseRepository(DoggisContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task Add(TEntity entity)
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
        }


        public virtual async Task AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _dbContext.Add(entity);
            }

            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task Delete(object id)
        {
            var entity = await Get(id);
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> Get(object id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            
            await _dbContext.SaveChangesAsync();
        }
    }
}
