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
    [Route("api/fish")]
    public class FishController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FishController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll()
        {
            var fish = _service.FishService.GetAll(false);

            return Ok(fish);
        }

        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var fish = _service.FishService.GetOne(id, false);

            return Ok(fish);
        }
    }
}
