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
    [Route("api/challenges")]
    public class ChallengeController : ControllerBase
    {
        private readonly IServiceManager _service;
        public ChallengeController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var challenges = _service.ChallengeService.GetAll(false);

            return Ok(challenges);
        }
        [HttpGet("{challengeId:int}")]
        public OkObjectResult GetOne(int challengeId)
        {
            var challenge = _service.ChallengeService.GetOne(challengeId, false);

            return Ok(challenge);
        }
    }
}
