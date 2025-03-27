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
    [Route("api/users/{userId}/randomencounters")]
    [Authorize]
    public class UserRandomEncounterController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserRandomEncounterController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(string userId)
        {
            var userRe = _service.UserRandomencounterService.GetAll(userId, false);

            return Ok(userRe);
        }

        [HttpGet("{randomEncounterId:int}")]
        public OkObjectResult GetOne(string userId, int randomEncounterId)
        {
            var userRe = _service.UserRandomencounterService.GetOne(userId, randomEncounterId, false);

            return Ok(userRe);
        }
    }
}
