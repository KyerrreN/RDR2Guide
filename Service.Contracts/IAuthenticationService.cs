using Microsoft.AspNetCore.Identity;
using Shared.DTO;

namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication);
        Task<UserCredentialsDto> CreateToken(bool populateExp);
        Task<UserCredentialsDto> RefreshToken(TokenDto tokenDto);
    }
}
