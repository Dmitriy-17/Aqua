
using System;
using System.Data.Entity;
using Infrastructure.Contracts;
using Infrastructure.Contracts.Repo;

namespace AdoNet.Repo
{
    public class CreateRepository<TEntity> : BaseRepository, ICreateRepository<TEntity> where TEntity : class, IEntity 
    {
        public CreateRepository(DbContext context) : base(context)
        {
        }
        public async void Create(TEntity entity)
        {
            mContext.Set<TEntity>().Add(entity);
            await mContext.SaveChangesAsync();
        }
    }
}
