using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Fish
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Bait { get; set; }

        [Required]
        public bool IsLegendary { get; set; }

        // RL
        [Required]
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserFish> UserFish { get; } = [];
    }
}
