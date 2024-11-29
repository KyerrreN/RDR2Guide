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
                    Image = null,
                    LocationId = 4,
                },
                new Plant
                {
                    Id = 2,
                    Name = "Oleander Sage",
                    IsEdible = false,
                    Image = null,
                    LocationId = 6,
                },
                new Plant
                {
                    Id = 3,
                    Name = "American Ginseng",
                    IsEdible = true,
                    Image = null,
                    LocationId = 3,
                }
            );
        }
    }
}
