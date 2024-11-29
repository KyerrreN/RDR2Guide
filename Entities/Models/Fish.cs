using System.ComponentModel.DataAnnotations;

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

        // RL
        [Required]
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<User> Users { get; } = [];
        public ICollection<UserFish> UserFish { get; } = [];
    }
}
