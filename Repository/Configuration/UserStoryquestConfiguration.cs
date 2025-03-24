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
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    StoryquestId = 1,
                },
                new UserStoryquest
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    StoryquestId = 2,
                },
                new UserStoryquest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    StoryquestId = 1,
                },
                new UserStoryquest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    StoryquestId = 2,
                },
                new UserStoryquest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    StoryquestId = 3,
                },
                new UserStoryquest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    StoryquestId = 4,
                },
                new UserStoryquest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    StoryquestId = 5,
                },
                new UserStoryquest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    StoryquestId = 1,
                },
                new UserStoryquest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    StoryquestId = 2,
                },
                new UserStoryquest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    StoryquestId = 3,
                }
            );
        }
    }
}
