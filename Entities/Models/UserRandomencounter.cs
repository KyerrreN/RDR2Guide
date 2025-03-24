namespace Entities.Models
{
    public class UserRandomencounter
    {
        public string UserId { get; set; }
        public int RandomencounterId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Randomencounter Randomencounter { get; set; } = null!;
    }
}
