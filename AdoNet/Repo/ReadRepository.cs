using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Contracts;
using Infrastructure.Contracts.Repo;
using Infrastructure.Entities.Filter;

namespace AdoNet.Repo
{
    public class ReadRepository<TEntity> : BaseRepository, IReadRepository<TEntity> where TEntity : class, IEntity
    {
        public ReadRepository(DbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<TEntity>> GetAll(Func<IFilter, bool> predicate = null)
        {
            var query = from c in mContext.Set<TEntity>()
                orderby c.Id ascending
                select c;
            var result = await query.ToListAsync();

            return result;
        }

        public async Task<TEntity> GetById(int id)
        {
            var result = await mContext.Set<TEntity>().FindAsync(id);
            return result;
        }

        public TEntity GetFirstOfDefault(Func<IFilter, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
