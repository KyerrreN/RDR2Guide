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
    [Route("api/storyquests")]
    public class StoryQuestController : ControllerBase
    {
        private readonly IServiceManager _service;
        public StoryQuestController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public OkObjectResult GetAll()
        {
            var sq = _service.StoryquestService.GetAll(false);

            return Ok(sq);
        }
        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var sq = _service.StoryquestService.GetOne(id, false);

            return Ok(sq);
        }
    }
}
