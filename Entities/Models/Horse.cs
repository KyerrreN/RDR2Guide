using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserHorse> UserHorses { get; } = [];
    }
}
