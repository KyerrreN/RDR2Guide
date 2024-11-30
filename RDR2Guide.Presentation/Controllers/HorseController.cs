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
    [Route("api/horse")]
    public class HorseController : ControllerBase
    {
        private readonly IServiceManager _service;
        public HorseController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var horses = _service.HorseService.GetAll(false);

            return Ok(horses);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var horse = _service.HorseService.GetOne(id, false);

            return Ok(horse);
        }
    }
}
