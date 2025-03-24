namespace Entities.Models
{
    public class UserSidequest
    {
        public string UserId { get; set; }
        public int SidequestId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Sidequest Sidequest { get; set; } = null!;
    }
}
