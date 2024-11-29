using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Miscellaneous
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // RL

        public ICollection<User> Users { get; } = [];
        public ICollection<UserMiscellaneous> UserMiscellaneous { get; } = [];
    }
}
