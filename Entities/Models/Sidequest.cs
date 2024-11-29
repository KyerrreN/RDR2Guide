using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Sidequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Reward { get; set; }

        [Required]
        public string QuestGiver { get; set; }

        [Required]
        public bool IsMissable { get; set; }

        public int? MissableChapter { get; set; }

        public string? Image { get; set; }

        // RL
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<User> Users { get; } = [];
        public ICollection<UserSidequest> UserSidequests { get; } = [];

        public Collectible? Collectible { get; set; }
    }
}
