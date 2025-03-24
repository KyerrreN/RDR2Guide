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
    [Route("api/users/{userId:int}/sidequests")]
    [Authorize]
    public class UserSidequestController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserSidequestController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userSq = _service.UserSidequestService.GetAll(userId, false);

            return Ok(userSq);
        }

        [HttpGet("{sidequestId:int}")]
        public OkObjectResult GetOne(int userId, int sidequestId)
        {
            var userSq = _service.UserSidequestService.GetOne(userId, sidequestId, false);

            return Ok(userSq);
        }
    }
}
