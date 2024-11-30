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
    [Route("api/locations")]
    public class LocationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public LocationController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var locations = _service.LocationService.GetAll(false);

            return Ok(locations);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var location = _service.LocationService.GetOne(id, false);

            return Ok(location);
        }
    }
}
