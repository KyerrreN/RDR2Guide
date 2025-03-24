namespace Entities.Models
{
    public class UserMiscellaneous
    {
        public string UserId { get; set; }
        public int MiscellaneousId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Miscellaneous Miscellaneous { get; set; } = null!;
    }
}
