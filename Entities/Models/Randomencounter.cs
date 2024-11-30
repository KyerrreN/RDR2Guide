using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Randomencounter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // RL

        // Faction
        [Required]
        public int FactionId { get; set; }

        public Faction Faction { get; set; } = null!;

        // UserRandomencounter
        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserRandomencounter> UserRandomencounters { get; } = [];
    }
}
