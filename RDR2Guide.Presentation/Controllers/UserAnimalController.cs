using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RDR2Guide.Presentation.Extensions;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/animals")]
    [Authorize]
    public class UserAnimalController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserAnimalController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userAnimals = _service.UserAnimalService.GetAll(userId, false);

            return Ok(userAnimals);
        }

        [HttpGet("{animalId:int}")]
        public async Task<OkObjectResult> GetOne(int animalId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userAnimal = _service.UserAnimalService.GetOne(userId, animalId, false);

            return Ok(userAnimal);
        }
    }
}
