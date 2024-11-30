using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/plants")]
    public class PlantController : ControllerBase
    {
        private readonly IServiceManager _service;
        public PlantController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var plants = _service.PlantService.GetAll(false);

            return Ok(plants);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var plant = _service.PlantService.GetOne(id, false);

            return Ok(plant);
        }
    }
}
