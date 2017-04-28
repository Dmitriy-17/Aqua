
namespace Infrastructure.Contracts.Repo
{
    public interface IDeleteRepository<IEntity>
    {
        void Delete(int Id);
    }
}
