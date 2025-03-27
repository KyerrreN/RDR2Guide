using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RDR2Guide.Presentation.Extensions;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/horses")]
    [Authorize]
    public class UserHorseController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserHorseController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userHorses = _service.UserHorseService.GetAll(userId, false);

            return Ok(userHorses);
        }

        [HttpGet("{horseId:int}")]
        public async Task<OkObjectResult> GetOne(int horseId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userHorse = _service.UserHorseService.GetOne(userId, horseId, false);

            return Ok(userHorse);
        }
    }
}
