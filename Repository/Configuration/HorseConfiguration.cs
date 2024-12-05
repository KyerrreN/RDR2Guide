using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class HorseConfiguration : IEntityTypeConfiguration<Horse>
    {
        // https://reddead.fandom.com/wiki/Horse#Red_Dead_Redemption_2_2
        public void Configure(EntityTypeBuilder<Horse> builder)
        {
            builder.HasData
            (
                new Horse
                {
                    Id = 1,
                    Breed = "American Paint",
                    Health = 5,
                    Stamina = 5,
                    Speed = 4,
                    Acceleration = 4,
                    Handling = "Standard",
                    Image = "horses/1.webp",
                    LocationId = 7
                },
                new Horse
                {
                    Id = 2,
                    Breed = "American Standardbred",
                    Health = 3,
                    Stamina = 3,
                    Speed = 5,
                    Acceleration = 4,
                    Handling = "Race",
                    Image = "horses/2.webp",
                    LocationId = 1
                },
                new Horse
                {
                    Id = 3,
                    Breed = "Arabian",
                    Health = 6,
                    Stamina = 6,
                    Speed = 6,
                    Acceleration = 6,
                    Handling = "Elite",
                    Image = "horses/3.webp",
                    LocationId = 8
                },
                new Horse
                {
                    Id = 4,
                    Breed = "Turkoman",
                    Health = 7,
                    Stamina = 5,
                    Speed = 6,
                    Acceleration = 5,
                    Handling = "Standard",
                    Image = "horses/4.webp",
                    LocationId = 8
                },
                new Horse
                {
                    Id = 5,
                    Breed = "Appaloosa",
                    Health = 3,
                    Stamina = 4,
                    Speed = 3,
                    Acceleration = 3,
                    Handling = "Standard",
                    Image = "horses/5.webp",
                    LocationId = 12
                },
                new Horse
                {
                    Id = 6,
                    Breed = "Ardennes",
                    Health = 5,
                    Stamina = 4,
                    Speed = 3,
                    Acceleration = 3,
                    Handling = "Standard",
                    Image = "horses/6.webp",
                    LocationId = 14
                },
                new Horse
                {
                    Id = 7,
                    Breed = "Belgian Draft Horse",
                    Health = 3,
                    Stamina = 3,
                    Speed = 3,
                    Acceleration = 3,
                    Handling = "Heavy",
                    Image = "horses/7.webp",
                    LocationId = 1
                },
                new Horse
                {
                    Id = 8,
                    Breed = "Dutch Warmblood",
                    Health = 5,
                    Stamina = 6,
                    Speed = 4,
                    Acceleration = 3,
                    Handling = "Standard",
                    Image = "horses/8.webp",
                    LocationId = 1
                },
                new Horse
                {
                    Id = 9,
                    Breed = "Hungarian Half-bred",
                    Health = 5,
                    Stamina = 4,
                    Speed = 3,
                    Acceleration = 3,
                    Handling = "Standard",
                    Image = "horses/9.webp",
                    LocationId = 4
                },
                new Horse
                {
                    Id = 10,
                    Breed = "Kentucky Saddler",
                    Health = 3,
                    Stamina = 2,
                    Speed = 3,
                    Acceleration = 2,
                    Handling = "Standard",
                    Image = "horses/10.webp",
                    LocationId = 12
                }
            );
        }
    }
}
