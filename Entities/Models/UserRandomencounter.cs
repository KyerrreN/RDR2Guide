namespace Entities.Models
{
    public class UserRandomencounter
    {
        public int UserId { get; set; }
        public int RandomencounterId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Randomencounter Randomencounter { get; set; } = null!;
    }
}
