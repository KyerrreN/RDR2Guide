using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace RDR2Guide.Presentation.Extensions
{
    public class UserIdParser
    {
        private readonly UserManager<User> _userManager;

        public UserIdParser(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> ParseUserId(ClaimsPrincipal userPrincipal)
        {
            string? claim = (userPrincipal.FindFirst(ClaimTypes.Name)?.Value) 
                ?? throw new BadRequestException($"Forget JWT detected");

            var user = await _userManager.FindByNameAsync(claim) 
                ?? throw new NotFoundException("User does not exist");

            return user.Id;
        }
    }
}
