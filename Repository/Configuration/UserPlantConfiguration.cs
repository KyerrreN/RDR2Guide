using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserPlantConfiguration : IEntityTypeConfiguration<UserPlant>
    {
        public void Configure(EntityTypeBuilder<UserPlant> builder)
        {
            builder.HasKey(k => new { k.UserId, k.PlantId });

            builder.HasData
            (
                new UserPlant
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    PlantId = 1
                },
                new UserPlant
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    PlantId = 2
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 1
                },
                new UserPlant
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    PlantId = 3
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 4
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 5
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 6
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 7
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 8
                },
                new UserPlant
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    PlantId = 9
                }
            );
        }
    }
}
