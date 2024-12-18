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
    [Route("api/users/{userId:int}/plants")]
    public class UserPlantController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserPlantController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll(int userId)
        {
            var userPlants = _service.UserPlantService.GetAll(userId, false);

            return Ok(userPlants);
        }

        [HttpGet("{plantId:int}")]
        public OkObjectResult GetOne(int userId, int plantId)
        {
            var userPlant = _service.UserPlantService.GetOne(userId, plantId, false);

            return Ok(userPlant);
        }
    }
}
