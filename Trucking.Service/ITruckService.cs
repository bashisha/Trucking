using System;
using System.Collections.Generic;
using System.Text;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public interface ITruckService
    {
        IList<Truck> GetAllTrucks();
    }
}
