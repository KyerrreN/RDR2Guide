using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Models
{
    public class Miscellaneous
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // RL
        [JsonIgnore]
        public ICollection<User> Users { get; } = [];
        [JsonIgnore]
        public ICollection<UserMiscellaneous> UserMiscellaneous { get; } = [];
    }
}
