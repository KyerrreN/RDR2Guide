namespace Entities.Models
{
    public class UserCollectible
    {
        public int UserId { get; set; }
        public int CollectibleId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Collectible Collectible { get; set; } = null!;
    }
}
