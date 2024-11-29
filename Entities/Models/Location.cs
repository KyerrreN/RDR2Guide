using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public ICollection<Weapon> Weapons { get; } = [];
        [JsonIgnore]
        public ICollection<Horse> Horses { get; } = [];
        [JsonIgnore]
        public ICollection<Storyquest> Storyquests { get; } = [];
        [JsonIgnore]
        public ICollection<Sidequest> Sidequests { get; } = [];
        [JsonIgnore]
        public ICollection<Animal> Animals { get; } = [];
        [JsonIgnore]
        public ICollection<Plant> Plants { get; } = [];
        [JsonIgnore]
        public ICollection<Fish> Fish { get; } = [];
    }
}
