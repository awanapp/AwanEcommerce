using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanEcommerce.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        public Task<TEntity> Get(int Id);
        public Task<IEnumerable<TEntity>> GetAll();

        public Task Add(TEntity entity);
        public Task Update(TEntity entity);
        public Task Delete(int Id);

       public Task<int> Save();
    }
}
