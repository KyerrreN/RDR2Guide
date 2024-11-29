namespace Entities.Models
{
    public class UserFish
    {
        public int UserId { get; set; }
        public int FishId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Fish Fish { get; set; } = null!;
    }
}
