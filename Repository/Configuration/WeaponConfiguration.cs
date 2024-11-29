using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class WeaponConfiguration : IEntityTypeConfiguration<Weapon>
    {
        // https://reddead.fandom.com/wiki/Weapons_in_Redemption_2?so=search
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.HasData
            (
                new Weapon
                {
                    Id = 1,
                    Name = "Cattleman Revolver",
                    Damage = 1.7f,
                    Range = 2f,
                    FiringRate = 3f,
                    Accuracy = 2.8f,
                    Cost = 50,
                    IsUnique = false,
                    Image = null,
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 2,
                    Name = "Granger's Revolver",
                    Damage = 1.7f,
                    Range = 2f,
                    FiringRate = 3f,
                    Accuracy = 2.8f,
                    Cost = null,
                    IsUnique = true,
                    Image = null,
                    LocationId = 2
                },
                new Weapon
                {
                    Id = 3,
                    Name = "Schofield Revolver",
                    Damage = 1.9f,
                    Range = 2f,
                    FiringRate = 2.8f,
                    Accuracy = 3f,
                    Cost = 84,
                    IsUnique = false,
                    Image = null,
                    LocationId = 1
                }
            );
        }
    }
}
