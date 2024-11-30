using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        // https://reddead.fandom.com/wiki/Category:Animals_in_Redemption_2
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasData
            (
                new Animal
                {
                    Id = 1,
                    Name = "American Domestic Cat",
                    Hostility = "Friendly",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 1
                },
                new Animal
                {
                    Id = 2,
                    Name = "Cougar",
                    Hostility = "Enemy",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 3,
                    Name = "California Valley Coyote",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 4,
                    Name = "Bison",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 5,
                    Name = "Black-tailed Jackrabbit",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 6,
                    Name = "American Fox",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 7,
                    Name = "American Pronghorn Doe",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 8,
                    Name = "American Red Fox",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 9,
                    Name = "American Black Bear",
                    Hostility = "Aggressive",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 12
                },
                new Animal
                {
                    Id = 10,
                    Name = "American Crow",
                    Hostility = "Neutral",
                    Image = null,
                    IsLegendary = false,
                    LocationId = 12
                }
            );
        }
    }
}
