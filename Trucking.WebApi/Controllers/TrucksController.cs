using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Trucking.Entities.Models;
using Trucking.Service;
using Trucking.WebApi.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Cors;

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
        [EnableCors("AllAllOrginis")]
        [HttpGet]
        public IList<TruckVM> Get()
        {
            var list = _truckService.GetAll();
            return list.Select(t => new TruckVM(t)).ToList();
        }

        [EnableCors("AllAllOrginis")]
        [HttpPost]
        public void Post([FromBody]TruckVM truckVM)
        {
            var truck = truckVM.GetTruck();
            _truckService.Add(truck);
        }
    }
}