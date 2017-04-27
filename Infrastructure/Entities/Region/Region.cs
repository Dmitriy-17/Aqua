
using Infrastructure.Contracts;

namespace Infrastructure.Region
{
    public class Region : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
