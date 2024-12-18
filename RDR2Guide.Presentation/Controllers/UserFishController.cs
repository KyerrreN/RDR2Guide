﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/users/{userId:int}/fish")]
    public class UserFishController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserFishController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userFish = _service.UserFishService.GetAll(userId, false);

            return Ok(userFish);
        }

        [HttpGet("{fishId:int}")]
        public OkObjectResult GetOne(int userId, int fishId)
        {
            var userFish = _service.UserFishService.GetOne(userId, fishId, false);

            return Ok(userFish);
        }
    }
}
