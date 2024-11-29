using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Tablegame
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // RL
        public ICollection<User> Users { get; } = [];
        public ICollection<UserTablegame> UserTablegames { get; } = [];
    }
}
