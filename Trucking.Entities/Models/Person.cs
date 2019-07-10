using Repository.Pattern.Ef6;

namespace Trucking.Entities.Models
{
    public class Person : Entity
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
