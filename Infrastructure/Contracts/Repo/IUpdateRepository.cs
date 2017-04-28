
namespace Infrastructure.Contracts.Repo
{
    public interface IUpdateRepository<IEntity>
    {
        void Updade(IEntity entity);
    }
}
