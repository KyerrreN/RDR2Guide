using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RDR2Guide.Presentation.Extensions;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/tablegames")]
    [Authorize]
    public class UserTablegameController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserTablegameController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userTablegames = _service.UserTablegameService.GetAll(userId, false);

            return Ok(userTablegames);
        }

        [HttpGet("{tablegameId:int}")]
        public async Task<OkObjectResult> GetOne(int tablegameId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userTablegame = _service.UserTablegameService.GetOne(userId, tablegameId, false);

            return Ok(userTablegame);
        }
        [HttpPost("{tablegameId:int}")]
        public async Task<StatusCodeResult> Collect(int tablegameId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserTablegameService.Collect(userId, tablegameId);

            return StatusCode(201);
        }
        [HttpDelete("{tablegameId:int}")]
        public async Task<StatusCodeResult> Delete(int tablegameId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserTablegameService.Delete(userId, tablegameId);

            return StatusCode(204);
        }
    }
}
