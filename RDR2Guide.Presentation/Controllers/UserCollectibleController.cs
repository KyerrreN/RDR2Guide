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
    [Route("api/users/collectibles")]
    [Authorize]
    public class UserCollectibleController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserCollectibleController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userCollectibles = _service.UserCollectibleService.GetAll(userId, false);

            return Ok(userCollectibles);
        }

        [HttpGet("{collectibleId:int}")]
        public async Task<OkObjectResult> GetOne(int collectibleId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userCollectible = _service.UserCollectibleService.GetOne(userId, collectibleId, false);

            return Ok(userCollectible);
        }
    }
}
