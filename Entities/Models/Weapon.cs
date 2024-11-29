using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Damage { get; set; }

        [Required]
        public float Range { get; set; }

        public float FiringRate { get; set; }

        [Required]
        public float Accuracy { get; set; }

        public int? Cost { get; set; }

        [Required]
        public bool IsUnique { get; set; }

        public string? Image { get; set; }

        // RELATIONSHIPS

        // Location
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        // UserWeapon
        public ICollection<User> Users { get; } = [];
        public ICollection<UserWeapon> UserWeapons { get; } = [];
    }
}
