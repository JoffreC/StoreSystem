using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StoreSystem.DAL.DBContext;
using StoreSystem.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace StoreSystem.DAL.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly DbVentaContext _dbContext;

        public GenericRepository(DbVentaContext dbVentaContext)
        {
            _dbContext = dbVentaContext;
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                TEntity entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
                return entity;
            }
            catch
            {
                throw;
            }
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entity);
                TEntity entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public Task<bool> Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }



        

        public Task<IQueryable<TEntity>> Search(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
