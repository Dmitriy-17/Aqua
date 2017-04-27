
using Infrastructure.Contracts;

namespace Infrastructure.User
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
