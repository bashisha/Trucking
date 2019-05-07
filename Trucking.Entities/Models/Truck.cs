using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Truck: Entity
    {
        public Truck() { }
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public long Mileage { get; set; }
        public Driver Driver { get; set; }
        public int WeightCapacityInTones { get; set; }
        public Owner Owner { get; set; }
        public string CurrentCity { get; set; }        

    }
}
