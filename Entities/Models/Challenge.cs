using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Challenge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public byte Rank { get; set; }

        [Required]
        public string Reward { get; set; }

        // RL
        public ICollection<User> Users { get; } = [];
        public ICollection<UserChallenge> UserChallenges { get; } = [];
    }
}
