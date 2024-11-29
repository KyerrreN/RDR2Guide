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
                    UserId = 2,
                    PlantId = 2
                }
            );
        }
    }
}
