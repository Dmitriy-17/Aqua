
namespace Infrastructure.Contracts.Repo
{
    interface IDeleteRepository<TEntity> where TEntity : IEntity
    {
        void Delete(int Id);
    }
}
