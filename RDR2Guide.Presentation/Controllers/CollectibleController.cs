using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/collectibles")]
    public class CollectibleController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CollectibleController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public OkObjectResult GetAll()
        {
            var collectibles = _service.CollectibleService.GetAll(false);

            return Ok(collectibles);
        }

        [HttpGet("{id:int}")]
        public OkObjectResult GetOne(int id)
        {
            var collectible = _service.CollectibleService.GetOne(id, false);

            return Ok(collectible);
        }
    }
}
