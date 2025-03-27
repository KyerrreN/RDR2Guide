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
    [Route("api/users/{userId}/collectibles")]
    [Authorize]
    public class UserCollectibleController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserCollectibleController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(string userId)
        {
            var userCollectibles = _service.UserCollectibleService.GetAll(userId, false);

            return Ok(userCollectibles);
        }

        [HttpGet("{collectibleId:int}")]
        public OkObjectResult GetOne(string userId, int collectibleId)
        {
            var userCollectible = _service.UserCollectibleService.GetOne(userId, collectibleId, false);

            return Ok(userCollectible);
        }
    }
}
