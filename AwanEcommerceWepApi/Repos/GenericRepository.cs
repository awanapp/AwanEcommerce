using AwanEcommerce.Infrastructure;
using AwanEcommerce.WepApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwanEcommerce.WepApi.Repos
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        AppdbContext appdbContext;

        public GenericRepository(AppdbContext appdbContext)
        {
            this.appdbContext = appdbContext;
        }
        public async Task Add(TEntity entity)
        {
           await appdbContext.AddAsync<TEntity>(entity);
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> Get(int Id)
        {
            return await appdbContext.FindAsync<TEntity>(Id);
             
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
