namespace Entities.Models
{
    public class UserSidequest
    {
        public int UserId { get; set; }
        public int SidequestId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Sidequest Sidequest { get; set; } = null!;
    }
}
