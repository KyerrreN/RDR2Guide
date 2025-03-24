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
    [Route("api/users/{userId:int}/animals")]
    [Authorize]
    public class UserAnimalController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserAnimalController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userAnimals = _service.UserAnimalService.GetAll(userId, false);

            return Ok(userAnimals);
        }

        [HttpGet("{animalId:int}")]
        public OkObjectResult GetOne(int userId, int animalId)
        {
            var userAnimal = _service.UserAnimalService.GetOne(userId, animalId, false);

            return Ok(userAnimal);
        }
    }
}
