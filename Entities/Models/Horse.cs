using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Horse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Breed { get; set; }   

        [Required]
        public byte Health { get; set; }

        [Required]
        public byte Stamina { get; set; }

        [Required]
        public byte Speed { get; set; }

        [Required]
        public byte Acceleration { get; set; }

        [Required]
        public string Handling { get; set; }

        public string? Image { get; set; }

        // RELATIONSHIPS

        // LOCATION
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        // USERHORSE
        public ICollection<User> Users { get; } = [];
        public ICollection<UserHorse> UserHorses { get; } = [];
    }
}
