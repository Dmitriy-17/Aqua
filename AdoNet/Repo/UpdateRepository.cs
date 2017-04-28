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
    public class UpdateRepository<TEntity> : BaseRepository, IUpdateRepository<TEntity> where TEntity : class, IEntity
    {
        public UpdateRepository(DbContext context) : base(context)
        {

        }
        public async void Updade(TEntity entity)
        {
            var temp = await mContext.Set<TEntity>().FindAsync(entity.Id);
            if (temp != null)
            {
                mContext.Entry(entity).State = EntityState.Modified;
                await mContext.SaveChangesAsync();
            }

        }
    }
}
