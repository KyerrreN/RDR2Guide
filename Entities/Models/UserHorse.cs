
namespace Entities.Models
{
    public class UserHorse
    {
        public int UserId { get; set; }
        public int HorseId { get; set; }

        // rl
        public User User { get; set; } = null!;
        public Horse Horse { get; set; } = null!;
    }
}
