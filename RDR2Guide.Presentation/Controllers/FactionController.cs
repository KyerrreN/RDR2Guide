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
    [Route("api/factions")]
    public class FactionController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FactionController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll()
        {
            var factions = _service.FactionService.GetAll(false);

            return Ok(factions);
        }

        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var faction = _service.FactionService.GetOne(id, false);

            return Ok(faction);
        }
    }
}
