using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RDR2Guide.Presentation.Extensions;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/miscellaneous")]
    [Authorize]
    public class UserMiscellaneousController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserMiscellaneousController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userMiscellaneous = _service.UserMiscellaneousService.GetAll(userId, false);

            return Ok(userMiscellaneous);
        }

        [HttpGet("{miscellaneousId:int}")]
        public async Task<OkObjectResult> GetOne(int miscellaneousId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userMiscellaneous = _service.UserMiscellaneousService.GetOne(userId, miscellaneousId, false);

            return Ok(userMiscellaneous);
        }
    }
}
