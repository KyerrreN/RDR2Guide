using System.ComponentModel.DataAnnotations;

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
        public ICollection<User> Users { get; } = [];
        public ICollection<UserRandomencounter> UserRandomencounters { get; } = [];
    }
}
