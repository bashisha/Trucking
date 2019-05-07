using System.Collections.Generic;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public interface ITruckService
    {
        IList<Truck> GetAll();
        void Add(Truck truck);
        void Update(Truck truck);
        void Delete(Truck truck);
    }
}
