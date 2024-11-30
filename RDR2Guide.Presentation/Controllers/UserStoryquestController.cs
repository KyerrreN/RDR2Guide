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
    [Route("api/users/{userId:int}/storyquests")]
    public class UserStoryquestController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserStoryquestController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userSq = _service.UserStoryquestService.GetAll(userId, false);

            return Ok(userSq);
        }

        [HttpGet("{storyquestId:int}")]
        public OkObjectResult GetOne(int userId, int storyquestId)
        {
            var userSq = _service.UserStoryquestService.GetOne(userId, storyquestId, false);

            return Ok(userSq);
        }
    }
}
