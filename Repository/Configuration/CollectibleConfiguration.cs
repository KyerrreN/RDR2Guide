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
                    SidequestId = 2    
                },
                new Collectible
                {
                    Id = 3,
                    Name = "Dinosaur Bones",
                    Amount = 30,
                    Image = null,
                    SidequestId = 3
                },
                new Collectible
                {
                    Id = 4,
                    Name = "Graves of your fallen companions",
                    Amount = 9,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 5,
                    Name = "Fish species",
                    Amount = 10,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 6,
                    Name = "Hunting requests",
                    Amount = 5,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 7,
                    Name = "Dreamcatchers",
                    Amount = 20,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 8,
                    Name = "Weapons",
                    Amount = 48,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 9,
                    Name = "Plant species",
                    Amount = 20,
                    Image = null,
                    SidequestId = null
                },
                new Collectible
                {
                    Id = 10,
                    Name = "Gangs",
                    Amount = 6,
                    Image = null,
                    SidequestId = null
                }
            );
        }
    }
}
