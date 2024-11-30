using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Hostility { get; set; }

        public string? Image { get; set; }

        [Required]
        public bool IsLegendary { get; set; }

        // RL
        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserAnimal> UserAnimals { get; } = [];

        public Location? Location { get; set; }
        public int? LocationId { get; set; }
    }
}
