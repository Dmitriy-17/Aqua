
namespace Infrastructure.Contracts.Repo
{
    public interface ICreateRepository<IEntity> 
    {
        void Create(IEntity entity);
    }
}
