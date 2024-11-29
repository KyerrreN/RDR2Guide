using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Miscellaneous
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Image { get; set; }

        // RL
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<User> Users { get; } = [];
        public ICollection<UserMiscellaneous> UserMiscellaneous { get; } = [];
    }
}
