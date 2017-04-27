using System;
using System.Collections.Generic;

namespace Infrastructure.Contracts.Repo
{
    interface IReadRepository<TEntity, IFilter> where TEntity : IEntity
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Func<IFilter, bool> predicate = null);
        TEntity GetFirstOfDefault(Func<IFilter, bool> predicate = null);
    }
}
