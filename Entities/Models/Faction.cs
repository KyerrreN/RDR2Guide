using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Faction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Leader { get; set; }

        [Required]
        public string Status { get; set; }

        // RL
        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserFaction> UserFactions { get; } = [];

        [JsonIgnore]
        public ICollection<Randomencounter> Randomencounters { get; } = [];
    }
}
