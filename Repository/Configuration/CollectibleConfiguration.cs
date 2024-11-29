using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CollectibleConfiguration : IEntityTypeConfiguration<Collectible>
    {
        // https://reddead.fandom.com/wiki/100%25_Completion_(RDR2)?so=search#Collectibles
        public void Configure(EntityTypeBuilder<Collectible> builder)
        {
            builder.HasData
            (
                new Collectible
                {
                    Id = 1,
                    Name = "Cigarette Cards",
                    Amount = 144,
                    Image = null,
                    SidequestId = 1
                },
                new Collectible
                {
                    Id = 2,
                    Name = "Rock Carvings",
                    Amount = 10,
                    Image = null,
                    SidequestId = 2,
                },
                new Collectible
                {
                    Id = 3,
                    Name = "Dinosaur Bones",
                    Amount = 30,
                    Image = null,
                    SidequestId = 3
                }
            );
        }
    }
}
