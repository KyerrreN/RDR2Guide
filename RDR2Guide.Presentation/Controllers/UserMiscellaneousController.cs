using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/{userId:int}/miscellaneous")]
    public class UserMiscellaneousController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserMiscellaneousController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userMiscellaneous = _service.UserMiscellaneousService.GetAll(userId, false);

            return Ok(userMiscellaneous);
        }

        [HttpGet("{miscellaneousId:int}")]
        public OkObjectResult GetOne(int userId, int miscellaneousId)
        {
            var userMiscellaneous = _service.UserMiscellaneousService.GetOne(userId, miscellaneousId, false);

            return Ok(userMiscellaneous);
        }
    }
}
