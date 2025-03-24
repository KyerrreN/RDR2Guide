using Entities.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;

namespace RDR2Guide.Presentation.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IValidator<UserForRegistrationDto> _userForRegistrationValidator;
        private readonly IValidator<UserForAuthenticationDto> _userForAuthenticationValidator;
        public AuthenticationController(IServiceManager service, IValidator<UserForRegistrationDto> userForRegistrationValidator, IValidator<UserForAuthenticationDto> userForAuthenticationValidator)
        {
            _service = service;
            _userForRegistrationValidator = userForRegistrationValidator;
            _userForAuthenticationValidator = userForAuthenticationValidator;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            if (userForRegistration is null)
                throw new BadRequestException("User for registration is null");

            _userForRegistrationValidator.ValidateAndThrow(userForRegistration);

            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (user is null)
                throw new BadRequestException("User information DTO is null");

            
            _userForAuthenticationValidator.ValidateAndThrow(user);

            if (!await _service.AuthenticationService.ValidateUser(user))
            {
                return Unauthorized();
            }

            return Ok(new { Token = await _service.AuthenticationService.CreateToken() });
        }
    }
}
