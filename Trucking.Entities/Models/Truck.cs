using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Truck: Entity
    {
        public Truck() { }
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal WeightCapacityInTones { get; set; }
    }
}
