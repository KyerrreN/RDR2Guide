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
    [Route("api/miscellaneous")]
    public class MiscellaneousController : ControllerBase
    {
        private readonly IServiceManager _service;
        public MiscellaneousController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var miscellaneous = _service.MiscellaneousService.GetAll(false);

            return Ok(miscellaneous);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var miscellaneous = _service.MiscellaneousService.GetOne(id, false);

            return Ok(miscellaneous);
        }
    }
}
