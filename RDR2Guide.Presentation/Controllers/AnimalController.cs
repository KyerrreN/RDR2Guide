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
    [Route("api/animals")]
    public class AnimalController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AnimalController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var animals = _service.AnimalService.GetAll(false);

            return Ok(animals);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var animal = _service.AnimalService.GetOne(id, false);

            return Ok(animal);
        }
    }
}
