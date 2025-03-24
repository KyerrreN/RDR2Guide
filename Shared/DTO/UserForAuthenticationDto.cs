namespace Shared.DTO
{
    public record UserForAuthenticationDto
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
