using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RDR2Guide.Presentation.Extensions;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/plants")]
    [Authorize]
    public class UserPlantController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserPlantController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userPlants = _service.UserPlantService.GetAll(userId, false);

            return Ok(userPlants);
        }

        [HttpGet("{plantId:int}")]
        public async Task<OkObjectResult> GetOne(int plantId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userPlant = _service.UserPlantService.GetOne(userId, plantId, false);

            return Ok(userPlant);
        }
        [HttpPost("{plantId:int}")]
        public async Task<StatusCodeResult> Collect(int plantId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserPlantService.Collect(userId, plantId);

            return StatusCode(201);
        }
        [HttpDelete("{plantId:int}")]
        public async Task<StatusCodeResult> Delete(int plantId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            await _service.UserPlantService.Delete(userId, plantId);

            return StatusCode(204);
        }
    }
}
