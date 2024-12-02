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
                    Image = "animals/1.webp",
                    IsLegendary = false,
                    LocationId = 1
                },
                new Animal
                {
                    Id = 2,
                    Name = "Cougar",
                    Hostility = "Enemy",
                    Image = "animals/2.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 3,
                    Name = "California Valley Coyote",
                    Hostility = "Neutral",
                    Image = "animals/3.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 4,
                    Name = "Bison",
                    Hostility = "Neutral",
                    Image = "animals/4.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 5,
                    Name = "Black-tailed Jackrabbit",
                    Hostility = "Neutral",
                    Image = "animals/5.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 6,
                    Name = "American Fox",
                    Hostility = "Neutral",
                    Image = "animals/6.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 7,
                    Name = "American Pronghorn Doe",
                    Hostility = "Neutral",
                    Image = "animals/7.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 8,
                    Name = "American Red Fox",
                    Hostility = "Neutral",
                    Image = "animals/8.webp",
                    IsLegendary = false,
                    LocationId = 3
                },
                new Animal
                {
                    Id = 9,
                    Name = "American Black Bear",
                    Hostility = "Enemy",
                    Image = "animals/9.webp",
                    IsLegendary = false,
                    LocationId = 12
                },
                new Animal
                {
                    Id = 10,
                    Name = "American Crow",
                    Hostility = "Neutral",
                    Image = "animals/10.webp",
                    IsLegendary = false,
                    LocationId = 12
                }
            );
        }
    }
}
