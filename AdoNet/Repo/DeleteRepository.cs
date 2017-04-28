using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Contracts;
using Infrastructure.Contracts.Repo;

namespace AdoNet.Repo
{
    public class DeleteRepository<TEntity> : BaseRepository, IDeleteRepository<TEntity> where TEntity : class, IEntity
    {
        public DeleteRepository(DbContext context) : base(context)
        {
            
        }
        public async void Delete(int Id)
        {
            var entity = await mContext.Set<TEntity>().FindAsync(Id);
            if (entity != null)
            {
                mContext.Set<TEntity>().Remove(entity);
                mContext.SaveChanges();
            }
        }
    }
}
