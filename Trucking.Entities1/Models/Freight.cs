namespace Trucking.Entities.Models
{
    public class Freight
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
    }
}
