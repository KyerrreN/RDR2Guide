namespace Entities.Models
{
    public class UserTablegame
    {
        public string UserId { get; set; }
        public int TablegameId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Tablegame Tablegame { get; set; } = null!;
    }
}
