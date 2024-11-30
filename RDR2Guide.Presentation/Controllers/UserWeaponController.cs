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
    [Route("api/users/{userId:int}/weapons")]
    public class UserWeaponController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserWeaponController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userWeapons = _service.UserWeaponService.GetAll(userId, false);

            return Ok(userWeapons);
        }

        [HttpGet("{weaponId:int}")]
        public OkObjectResult GetOne(int userId, int weaponId)
        {
            var userWeapon = _service.UserWeaponService.GetOne(userId, weaponId, false);

            return Ok(userWeapon);
        }
    }
}
