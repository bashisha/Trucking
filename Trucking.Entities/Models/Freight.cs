using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Freight : Entity
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
    }
}
