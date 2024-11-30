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
    [Route("api/users/{userId:int}/horses")]
    public class UserHorseController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserHorseController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userHorses = _service.UserHorseService.GetAll(userId, false);

            return Ok(userHorses);
        }

        [HttpGet("{horseId:int}")]
        public OkObjectResult GetOne(int userId, int horseId)
        {
            var userHorse = _service.UserHorseService.GetOne(userId, horseId, false);

            return Ok(userHorse);
        }
    }
}
