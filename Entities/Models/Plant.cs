using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsEdible { get; set; }

        public string? Image { get; set; }

        // RL
        public Location Location { get; set; } = null!;

        [Required]
        public int LocationId { get; set; }

        public ICollection<User> Users { get; } = [];
        public ICollection<UserPlant> UserPlants { get; } = [];
    }
}
