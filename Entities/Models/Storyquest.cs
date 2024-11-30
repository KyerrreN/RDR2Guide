using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserStoryquest> UserStoryquests { get; } = [];

    }
}
