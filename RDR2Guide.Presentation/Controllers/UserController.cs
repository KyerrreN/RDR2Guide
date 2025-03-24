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
    [Route("api/users")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UserController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll()
        {
            var users = _service.UserService.GetAll(false);

            return Ok(users);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetById(int id)
        {
            var user = _service.UserService.GetOne(id, false);

            return Ok(user);
        }
    }
}

