using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            // https://reddead.fandom.com/wiki/Plant_Gathering_in_Redemption_2?so=search#Types_of_Plants_and_Herbs
            builder.HasData
            (
                new Plant
                {
                    Id = 1,
                    Name = "Alaskan Ginseng",
                    IsEdible = true,
                    Image = "plants/1.webp",
                    LocationId = 4,
                },
                new Plant
                {
                    Id = 2,
                    Name = "Oleander Sage",
                    IsEdible = false,
                    Image = "plants/2.webp",
                    LocationId = 6,
                },
                new Plant
                {
                    Id = 3,
                    Name = "American Ginseng",
                    IsEdible = true,
                    Image = "plants/3.webp",
                    LocationId = 3,
                },
                new Plant
                {
                    Id = 4,
                    Name = "Hummingbird Sage",
                    IsEdible = false,
                    Image = "plants/4.webp",
                    LocationId = 14,
                },
                new Plant
                {
                    Id = 5,
                    Name = "Golden Currant",
                    IsEdible = false,
                    Image = "plants/5.webp",
                    LocationId = 4,
                },
                new Plant
                {
                    Id = 6,
                    Name = "English Mace",
                    IsEdible = false,
                    Image = "plants/6.webp",
                    LocationId = 12,
                },
                new Plant
                {
                    Id = 7,
                    Name = "Desert Sage",
                    IsEdible = true,
                    Image = "plants/7.webp",
                    LocationId = 15,
                },
                new Plant
                {
                    Id = 8,
                    Name = "Common Bulrush",
                    IsEdible = false,
                    Image = "plants/8.webp",
                    LocationId = 6,
                },
                new Plant
                {
                    Id = 9,
                    Name = "Blackcurrant",
                    IsEdible = false,
                    Image = "plants/9.webp",
                    LocationId = 12,
                },
                new Plant
                {
                    Id = 10,
                    Name = "Burdock Root",
                    IsEdible = true,
                    Image = "plants/10.webp",
                    LocationId = 4,
                }
            );
        }
    }
}
