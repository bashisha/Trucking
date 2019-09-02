using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
//using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
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

        [EnableCors("AllAllOrginis")]
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
            var fr = new Freight
            {
                Weight = freight.WeightInTonnes,
                FreightType = freight.FreightType,
                FromCity = freight.FromZipCode,
                ToCity= freight.ToZipCode
            };
              _freightService.Add(fr);
        }

        [HttpPost("uploadfiles")]
        [DisableRequestSizeLimit]
        [Route("api/freights/upload")]
        [EnableCors("AllAllOrginis")]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // Of course this action exist in microsoft docs and you can read it.
        [HttpPost("UploadMultipleFiles")]
        [Route("api/freights/uploadfiles")]
        [EnableCors("AllAllOrginis")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {

            long size = files.Sum(f => f.Length);

            // Full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                    using (var stream = new FileStream(filePath, FileMode.Create))
                        await formFile.CopyToAsync(stream);
            }

            // Process uploaded files

            return Ok(new { count = files.Count, path = filePath });
        }

    }
}