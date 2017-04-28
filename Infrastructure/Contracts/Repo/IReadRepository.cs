using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Repo
{
    public interface IReadRepository<IEntity>
    {
        Task<IEntity> GetById(int id);
        Task<IEnumerable<IEntity>> GetAll(Func<IFilter, bool> predicate = null);
        IEntity GetFirstOfDefault(Func<IFilter, bool> predicate = null);
    }
}
