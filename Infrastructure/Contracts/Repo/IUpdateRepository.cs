
namespace Infrastructure.Contracts.Repo
{
    interface IUpdateRepository<TEntity> where TEntity : IEntity
    {
        void Updade(TEntity entity);
    }
}
