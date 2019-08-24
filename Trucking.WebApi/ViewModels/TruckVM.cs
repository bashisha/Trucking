using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trucking.Entities.Models;

namespace Trucking.WebApi.ViewModels
{
    public class TruckVM
    {
        public TruckVM() { }
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public long Mileage { get; set; }
        public int WeightCapacityInTones { get; set; }
        public string DriverName { get; set; }
        public string OwnerName { get; set; }
        public string CurrentCity { get; set; }
        public TruckVM(Truck truck)
        {
            this.Id = truck.Id;
            this.Model = truck.Model;
            this.Manufacturer = truck.Manufacturer;
            this.Mileage = truck.Mileage;
            this.WeightCapacityInTones = truck.WeightCapacityInTones;
            var driver = truck.Driver;
            this.DriverName =( driver!=null ? GetFullName(driver.LastName, driver.FirstName):"");
            var owner = truck.Owner;
            this.OwnerName = (owner!=null? GetFullName(owner.LastName, owner.FirstName):"");
            this.CurrentCity = truck.CurrentCity;
        }

        internal Truck GetTruck()
        {
            return new Truck
            {
                Id = this.Id,
                Model = this.Model,
                Manufacturer = this.Manufacturer,
                Mileage = this.Mileage,
                WeightCapacityInTones = this.WeightCapacityInTones,
                CurrentCity = this.CurrentCity
                
            };
        }

        public string GetFullName(string lastName, string firstName)
        {
            string fullName = (lastName ?? "") + ", " + (firstName ?? "");
            return fullName;
        }
    }
}
