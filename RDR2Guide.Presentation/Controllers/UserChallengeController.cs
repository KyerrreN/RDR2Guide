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
    [Route("api/users/{userId}/challenges")]
    [Authorize]
    public class UserChallengeController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserChallengeController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(string userId)
        {
            var userChallenges = _service.UserChallengeService.GetAll(userId, false);

            return Ok(userChallenges);
        }

        [HttpGet("{challengeId:int}")]
        public OkObjectResult GetOne(string userId, int challengeId)
        {
            var userChallenge = _service.UserChallengeService.GetOne(userId, challengeId, false);

            return Ok(userChallenge);
        }
    }
}
