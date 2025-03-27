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
    [Route("api/users/randomencounters")]
    [Authorize]
    public class UserRandomEncounterController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserRandomEncounterController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userRe = _service.UserRandomencounterService.GetAll(userId, false);

            return Ok(userRe);
        }

        [HttpGet("{randomEncounterId:int}")]
        public async Task<OkObjectResult> GetOne(int randomEncounterId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userRe = _service.UserRandomencounterService.GetOne(userId, randomEncounterId, false);

            return Ok(userRe);
        }
    }
}
