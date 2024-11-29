namespace Entities.Models
{
    public class UserFaction
    {
        public int UserId { get; set; }
        public int FactionId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Faction Faction { get; set; } = null!;
    }
}
