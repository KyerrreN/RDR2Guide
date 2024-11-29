using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserStoryquestConfiguration : IEntityTypeConfiguration<UserStoryquest>
    {
        public void Configure(EntityTypeBuilder<UserStoryquest> builder)
        {
            builder.HasKey(k => new { k.UserId, k.StoryquestId });

            builder.HasData
            (
                new UserStoryquest
                {
                    UserId = 1,
                    StoryquestId = 1,
                },
                new UserStoryquest
                {
                    UserId = 1,
                    StoryquestId = 2,
                },
                new UserStoryquest
                {
                    UserId = 2,
                    StoryquestId = 1,
                },
                new UserStoryquest
                {
                    UserId = 2,
                    StoryquestId = 2,
                }
            );
        }
    }
}
