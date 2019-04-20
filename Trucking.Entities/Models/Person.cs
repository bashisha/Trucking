using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trucking.Entities.Models
{
    public class Person : Entity
    {        
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        Address Address { get; set; }
    }
}
