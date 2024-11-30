using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserPlant> UserPlants { get; } = [];
    }
}
