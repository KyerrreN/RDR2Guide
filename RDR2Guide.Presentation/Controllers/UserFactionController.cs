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
    [Route("api/users/factions")]
    [Authorize]
    public class UserFactionController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserFactionController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userFaction = _service.UserFactionService.GetAll(userId, false);

            return Ok(userFaction);
        }

        [HttpGet("{factionId:int}")]
        public async Task<OkObjectResult> GetOne(int factionId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userFaction = _service.UserFactionService.GetOne(userId, factionId, false);

            return Ok(userFaction);
        }
        [HttpPost("{factionId:int}")]
        public async Task<StatusCodeResult> Collect(int factionId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserFactionService.Collect(userId, factionId);

            return StatusCode(201);
        }
        [HttpDelete("{factionId:int}")]
        public async Task<StatusCodeResult> Delete(int factionId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserFactionService.Delete(userId, factionId);

            return StatusCode(204);
        }
    }
}
