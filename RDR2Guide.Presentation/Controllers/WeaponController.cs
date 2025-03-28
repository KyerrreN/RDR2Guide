using Microsoft.AspNetCore.Authorization;
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
    [Route("api/weapons")]
    public class WeaponController : ControllerBase
    {
        private readonly IServiceManager _service;
        public WeaponController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll()
        {
            var weapons = _service.WeaponService.GetAll(false);

            return Ok(weapons);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetById(int id)
        {
            var weapon = _service.WeaponService.GetOne(id, false);

            return Ok(weapon);
        }
    }
}
