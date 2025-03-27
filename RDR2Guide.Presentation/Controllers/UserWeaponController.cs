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
    [Route("api/users/weapons")]
    [Authorize]
    public class UserWeaponController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserIdParser _userIdParser;

        public UserWeaponController(IServiceManager service, UserIdParser userIdParser)
        {
            _service = service;
            _userIdParser = userIdParser;
        }

        [HttpGet]
        public async Task<OkObjectResult> GetAll()
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userWeapons = _service.UserWeaponService.GetAll(userId, false);

            return Ok(userWeapons);
        }

        [HttpGet("{weaponId:int}")]
        public async Task<OkObjectResult> GetOne(int weaponId)
        {
            var userId = await _userIdParser.ParseUserId(User);
            var userWeapon = _service.UserWeaponService.GetOne(userId, weaponId, false);

            return Ok(userWeapon);
        }
    }
}
