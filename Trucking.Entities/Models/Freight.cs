using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Freight : Entity
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string FreightType { get; set; }        
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public string Image { get; set; }
    }
}
