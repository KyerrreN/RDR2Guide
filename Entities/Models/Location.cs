using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Image { get; set; }

        // RELATIONSHIPS
        public ICollection<Weapon> Weapons { get; } = [];
        public ICollection<Horse> Horses { get; } = [];
        public ICollection<Storyquest> Storyquests { get; } = [];
        public ICollection<Sidequest> Sidequests { get; } = [];
        public ICollection<Animal> Animals { get; } = [];
        public ICollection<Plant> Plants { get; } = [];
        public ICollection<Miscellaneous> Miscellaneous { get; } = [];
        public ICollection<Fish> Fish { get; } = [];
    }
}
