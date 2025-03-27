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
    [Route("api/users/storyquests")]
    [Authorize]
    public class UserStoryquestController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserStoryquestController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userSq = _service.UserStoryquestService.GetAll(userId, false);

            return Ok(userSq);
        }

        [HttpGet("{storyquestId:int}")]
        public async Task<OkObjectResult> GetOne(int storyquestId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userSq = _service.UserStoryquestService.GetOne(userId, storyquestId, false);

            return Ok(userSq);
        }
        [HttpPost("{storyQuestId:int}")]
        public async Task<StatusCodeResult> Collect(int storyQuestId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserStoryquestService.Collect(userId, storyQuestId);

            return StatusCode(201);
        }
        [HttpDelete("{storyQuestId:int}")]
        public async Task<StatusCodeResult> Delete(int storyQuestId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserStoryquestService.Delete(userId, storyQuestId);

            return StatusCode(204);
        }
    }
}
