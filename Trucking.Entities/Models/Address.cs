using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trucking.Entities.Models
{
   public class Address : Entity
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string AddressLine { get; set; }
    }
}
