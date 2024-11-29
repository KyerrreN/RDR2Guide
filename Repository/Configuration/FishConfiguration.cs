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
                }
            );
        }
    }
}
