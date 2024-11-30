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
                },
                new Storyquest
                {
                    Id = 4,
                    Number = 1,
                    Name = "Angelo Bronte, A Man of Honor",
                    Reward = null,
                    Image = null,
                    LocationId = 13
                },
                new Storyquest
                {
                    Id = 5,
                    Number = 1,
                    Name = "Help a Brother Out",
                    Reward = "$1.00 (Optional)",
                    Image = null,
                    LocationId = 13
                },
                new Storyquest
                {
                    Id = 6,
                    Number = 1,
                    Name = "Hell Hath No Fury",
                    Reward = null,
                    Image = null,
                    LocationId = 16
                },
                new Storyquest
                {
                    Id = 7,
                    Number = 1,
                    Name = "Paradise Mercifully Departed",
                    Reward = null,
                    Image = null,
                    LocationId = 16
                },
                new Storyquest
                {
                    Id = 8,
                    Number = 1,
                    Name = "Dear Uncle Tacitus",
                    Reward = null,
                    Image = null,
                    LocationId = 3
                },
                new Storyquest
                {
                    Id = 9,
                    Number = 1,
                    Name = "That's Murfree Country",
                    Reward = "Mauser Pistol available in gunsmiths, Unlocks Legendary Bullgator",
                    Image = null,
                    LocationId = 3
                },
                new Storyquest
                {
                    Id = 10,
                    Number = 1,
                    Name = "A Fork in the Road",
                    Reward = null,
                    Image = null,
                    LocationId = 13
                }
            );
        }
    }
}
