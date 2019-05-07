using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Trucking.Entities.Models;
using Trucking.Service;
using Trucking.WebApi.ViewModels;

namespace Trucking.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Freights")]
    public class FreightsController : Controller
    {
        private readonly IFreightService _freightService;
        public FreightsController(IFreightService freightService)
        {
            _freightService = freightService;
        }

        [HttpGet]
        public IList<FreightVM> Get()
        {
            var freights = _freightService.GetAll();
            var list = new List<FreightVM>();
            foreach (Freight freight in freights)
            {
                var freightVM = new FreightVM();
                freightVM.Id = freight.Id;
                freightVM.FreightType = freight.FreightType;
                //freightVM.FromZipCode = freight.FromAddress.ZipCode;
                //freightVM.ToZipCode = freight.ToAddress.ZipCode;
                freightVM.TotalDistance = 123;
                freightVM.WeightInTonnes = freight.Weight;
                freightVM.Image = freight.Image;
                list.Add(freightVM);
            }
            return list;
        }

        [HttpPost]
        public void Post([FromBody]FreightVM freight)
        {
            //  _freightService.Add(freight);
        }
    }
}