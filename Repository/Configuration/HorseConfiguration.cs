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
                    Image = null,
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
                    Image = null,
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
                    Image = null,
                    LocationId = 8
                }
            );
        }
    }
}
