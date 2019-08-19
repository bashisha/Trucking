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
        public TruckVM(Truck truck)
        {
            this.Id = truck.Id;
            this.Model = truck.Model;
            this.Manufacturer = truck.Manufacturer;
            this.Mileage = truck.Mileage;
            this.WeightCapacityInTones = truck.WeightCapacityInTones;
            this.DriverName = GetFullName(truck.Driver.LastName, truck.Driver.FirstName);
            this.OwnerName = GetFullName(truck.Owner.LastName, truck.Driver.FirstName);
        }

        internal Truck GetTruck()
        {
            return new Truck
            {
                Id = this.Id,
                Model = this.Model,
                Manufacturer = this.Manufacturer,
                Mileage = this.Mileage,
                WeightCapacityInTones = this.WeightCapacityInTones
            };
        }

        public string GetFullName(string lastName, string firstName)
        {
            string fullName = (lastName ?? "") + ", " + (firstName ?? "");
            return fullName;
        }
    }
}
