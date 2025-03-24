using Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/token")]
    public class TokenControler : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TokenControler(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            if (tokenDto is null)
                throw new BadRequestException("Token Dto is null");

            var tokenDtoToReturn = await _serviceManager.AuthenticationService.RefreshToken(tokenDto);

            return Ok(tokenDtoToReturn);
        }
    }
}
