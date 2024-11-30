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
    [Route("api/randomencounter")]
    public class RandomEncounterController : ControllerBase
    {
        private readonly IServiceManager _service;
        public RandomEncounterController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var re = _service.RandomEncounterService.GetAll(false);

            return Ok(re);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var re = _service.RandomEncounterService.GetOne(id, false);

            return Ok(re);
        }
    }
}
