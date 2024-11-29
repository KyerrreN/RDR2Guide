namespace Entities.Models
{
    public class UserStoryquest
    {
        public int UserId { get; set; }
        public int StoryquestId { get; set; }

        // Rl
        public User User { get; set; } = null!;
        public Storyquest Storyquest { get; set; } = null!;
    }
}
