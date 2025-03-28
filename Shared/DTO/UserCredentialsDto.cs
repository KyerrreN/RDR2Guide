namespace Shared.DTO
{
    public record UserCredentialsDto
    {
        public string Username { get; set; }
        public string Nickname { get; set; }
        public TokenDto Tokens { get; set; }
    }
}
