using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trucking.Entities.Models;
using Trucking.Service;

namespace Trucking.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Trucks")]
    public class TrucksController : Controller
    {
        private readonly ITruckService _truckService;
        public TrucksController(ITruckService truckService)
        {
            _truckService = truckService;
        }

        public IList<Truck> Get()
        {
            return _truckService.GetAllTrucks();
        }
    }
}