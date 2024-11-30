using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class FishConfiguration : IEntityTypeConfiguration<Fish>
    {
        public void Configure(EntityTypeBuilder<Fish> builder)
        {
            builder.HasData
            (
                new Fish
                {
                    Id = 1,
                    Name = "Bluegill",
                    Bait = "Cheese",
                    IsLegendary = false,
                    LocationId = 4
                },
                new Fish
                {
                    Id = 2,
                    Name = "Largemouth Bass",
                    Bait = "Crayfish",
                    IsLegendary = false,
                    LocationId = 6
                },
                new Fish
                {
                    Id = 3,
                    Name = "Legendary Bluegill",
                    Bait = "Special Lake Lure",
                    IsLegendary = true,
                    LocationId = 5
                },
                new Fish
                {
                    Id = 4,
                    Name = "Bullhead Catfish",
                    Bait = "Corn",
                    IsLegendary = false,
                    LocationId = 14
                },
                new Fish
                {
                    Id = 5,
                    Name = "Legendary Bullhead Catfish",
                    Bait = "Special Swamp Lure",
                    IsLegendary = true,
                    LocationId = 14
                },
                new Fish
                {
                    Id = 6,
                    Name = "Chain Pickerel",
                    Bait = "Corn",
                    IsLegendary = false,
                    LocationId = 4
                },
                new Fish
                {
                    Id = 7,
                    Name = "Legendary Chain Pickerel",
                    Bait = "Special River Lure",
                    IsLegendary = true,
                    LocationId = 4
                },
                new Fish
                {
                    Id = 8,
                    Name = "Lake Sturgeon",
                    Bait = "Lake Lure",
                    IsLegendary = false,
                    LocationId = 14
                },
                new Fish
                {
                    Id = 9,
                    Name = "Legendary Lake Sturgeon",
                    Bait = "Special River Lure",
                    IsLegendary = true,
                    LocationId = 14
                },
                new Fish
                {
                    Id = 10,
                    Name = "Perch",
                    Bait = "Bread",
                    IsLegendary = false,
                    LocationId = 12
                }
            );
        }
    }
}
