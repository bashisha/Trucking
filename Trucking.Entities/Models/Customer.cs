using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Customer : Entity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}
