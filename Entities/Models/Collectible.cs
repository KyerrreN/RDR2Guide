using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Collectible
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte Amount { get; set; }

        public string? Image { get; set; }

        // RL
        public int? SidequestId { get; set; }
        public Sidequest? Sidequest { get; set; } = null!;

        public ICollection<User> Users { get; } = [];
        public ICollection<UserCollectible> UserCollectibles { get; } = [];
    }
}
