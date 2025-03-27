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
    [Route("api/users/fish")]
    [Authorize]
    public class UserFishController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserFishController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userFish = _service.UserFishService.GetAll(userId, false);

            return Ok(userFish);
        }

        [HttpGet("{fishId:int}")]
        public async Task<OkObjectResult> GetOne(int fishId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userFish = _service.UserFishService.GetOne(userId, fishId, false);

            return Ok(userFish);
        }
    }
}
