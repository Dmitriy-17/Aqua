
using Infrastructure.Enums;

namespace Infrastructure.Aquarium
{
    public class Aquarium
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public WaterType WaterType { get; set; }
        public bool IsCorals { get; set; }
        public bool IsPlants { get; set; }
        public bool IsFish { get; set; }
        public bool IsTurtle { get; set; }
        public bool IsOtherAnimals { get; set; }
    }
}
