using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/{userId:int}/tablegames")]
    public class UserTablegameController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserTablegameController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userTablegames = _service.UserTablegameService.GetAll(userId, false);

            return Ok(userTablegames);
        }

        [HttpGet("{tablegameId:int}")]
        public OkObjectResult GetOne(int userId, int tablegameId)
        {
            var userTablegame = _service.UserTablegameService.GetOne(userId, tablegameId, false);

            return Ok(userTablegame);
        }
    }
}
