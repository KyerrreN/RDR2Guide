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
    [Route("api/users/{userId:int}/factions")]
    public class UserFactionController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserFactionController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userFaction = _service.UserFactionService.GetAll(userId, false);

            return Ok(userFaction);
        }

        [HttpGet("{factionId:int}")]
        public OkObjectResult GetOne(int userId, int factionId)
        {
            var userFaction = _service.UserFactionService.GetOne(userId, factionId, false);

            return Ok(userFaction);
        }
    }
}
