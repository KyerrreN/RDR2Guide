namespace Shared.DTO
{
    public record UserForRegistrationDto
    {
        public string? Nickname { get; init; }
        public string? UserName { get; init; }
        public string? Password { get; init; }
        public ICollection<string>? Roles { get; init; }
    }
}
