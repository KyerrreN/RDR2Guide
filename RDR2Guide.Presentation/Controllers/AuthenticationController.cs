using Entities.Exceptions;
using Entities.Models;
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
        public AuthenticationController(IServiceManager service, IValidator<UserForRegistrationDto> userForRegistrationValidator)
        {
            _service = service;
            _userForRegistrationValidator = userForRegistrationValidator;
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
    }
}
