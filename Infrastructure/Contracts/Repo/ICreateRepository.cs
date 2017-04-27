
namespace Infrastructure.Contracts.Repo
{
    interface ICreateRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
    }
}
