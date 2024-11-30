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
    [Route("api/tablegames")]
    public class TableGameController : ControllerBase
    {
        private readonly IServiceManager _service;
        public TableGameController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var tablegames = _service.TablegameService.GetAll(false);

            return Ok(tablegames);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var tablegame = _service.TablegameService.GetOne(id, false);

            return Ok(tablegame);
        }
    }
}
