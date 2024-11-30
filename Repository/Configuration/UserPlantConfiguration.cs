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
                    UserId = 1,
                    PlantId = 1
                },
                new UserPlant
                {
                    UserId = 1,
                    PlantId = 2
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 1
                },
                new UserPlant
                {
                    UserId = 3,
                    PlantId = 3
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 4
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 5
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 6
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 7
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 8
                },
                new UserPlant
                {
                    UserId = 2,
                    PlantId = 9
                }
            );
        }
    }
}
