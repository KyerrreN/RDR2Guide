using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Storyquest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Reward { get; set; }

        public string? Image { get; set; }

        //RELATIONSHIPS
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<User> Users { get; } = [];
        public ICollection<UserStoryquest> UserStoryquests { get; } = [];

    }
}
