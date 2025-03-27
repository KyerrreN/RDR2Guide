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
    [Route("api/users/challenges")]
    [Authorize]
    public class UserChallengeController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserChallengeController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userChallenges = _service.UserChallengeService.GetAll(userId, false);

            return Ok(userChallenges);
        }

        [HttpGet("{challengeId:int}")]
        public async Task<OkObjectResult> GetOne(int challengeId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userChallenge = _service.UserChallengeService.GetOne(userId, challengeId, false);

            return Ok(userChallenge);
        }
        [HttpPost("{challengeId:int}")]
        public async Task<StatusCodeResult> Collect(int challengeId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserChallengeService.Collect(userId, challengeId);

            return StatusCode(201);
        }
        [HttpDelete("{challengeId:int}")]
        public async Task<StatusCodeResult> Delete(int challengeId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserChallengeService.Delete(userId, challengeId);

            return StatusCode(204);
        }
    }
}
