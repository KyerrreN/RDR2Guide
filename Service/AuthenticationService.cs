using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationService(UserManager<User> userManager, IConfiguration configuration, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
            {
                await AddToRolesIfExist(userForRegistration, user);
            }

            return result;
        }

        // Private
        private async Task AddToRolesIfExist(UserForRegistrationDto userForRegistration, User user)
        {
            bool allRolesExist = true;

            if (userForRegistration.Roles is not null &&
                userForRegistration.Roles.Count != 0)
            {
                foreach (string role in userForRegistration.Roles)
                {
                    if (await _roleManager.RoleExistsAsync(role) == false)
                    {
                        allRolesExist = false;
                        break;
                    }
                }

                if (allRolesExist)
                {
                    await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
                }
            }
        }
    }
}
