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
    [Route("api/users/{userId}/storyquests")]
    [Authorize]
    public class UserStoryquestController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserStoryquestController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(string userId)
        {
            var userSq = _service.UserStoryquestService.GetAll(userId, false);

            return Ok(userSq);
        }

        [HttpGet("{storyquestId:int}")]
        public OkObjectResult GetOne(string userId, int storyquestId)
        {
            var userSq = _service.UserStoryquestService.GetOne(userId, storyquestId, false);

            return Ok(userSq);
        }
    }
}
