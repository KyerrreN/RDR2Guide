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
    [Route("api/users/sidequests")]
    [Authorize]
    public class UserSidequestController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserSidequestController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userSq = _service.UserSidequestService.GetAll(userId, false);

            return Ok(userSq);
        }

        [HttpGet("{sidequestId:int}")]
        public async Task<OkObjectResult> GetOne(int sidequestId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userSq = _service.UserSidequestService.GetOne(userId, sidequestId, false);

            return Ok(userSq);
        }
    }
}
