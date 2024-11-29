namespace Entities.Models
{
    public class UserPlant
    {
        public int UserId { get; set; }
        public int PlantId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Plant Plant { get; set; } = null!;
    }
}
