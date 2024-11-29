using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class StoryquestConfiguration : IEntityTypeConfiguration<Storyquest>
    {
        public void Configure(EntityTypeBuilder<Storyquest> builder)
        {
            // https://reddead.fandom.com/wiki/Missions_in_Redemption_2?so=search#Chapter_1:_Colter
            builder.HasData
            (
                new Storyquest
                {
                    Id = 1,
                    Number = 1,
                    Name = "Outlaws from the West",
                    Reward = "Mahogany Boy Tennessee Walker",
                    Image = null,
                    LocationId = 9
                },
                new Storyquest
                {
                    Id = 2,
                    Number = 1,
                    Name = "Pouring Forth Oil I",
                    Reward = null,
                    Image = null,
                    LocationId = 10
                },
                new Storyquest
                {
                    Id = 3,
                    Number = 2,
                    Name = "Pouring Forth Oil II",
                    Reward = null,
                    Image = null,
                    LocationId = 11
                }
            );
        }
    }
}
