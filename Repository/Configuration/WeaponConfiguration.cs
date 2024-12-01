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
                    Image = "1.webp",
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
                    Image = "2.webp",
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
                    Image = "3.webp",
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 4,
                    Name = "Flaco's Revolver",
                    Damage = 1.7f,
                    Range = 2f,
                    FiringRate = 3f,
                    Accuracy = 2.8f,
                    Cost = null,
                    IsUnique = true,
                    Image = "4.webp",
                    LocationId = 12
                },
                new Weapon
                {
                    Id = 5,
                    Name = "Double-action Revolver",
                    Damage = 1.5f,
                    Range = 2f,
                    FiringRate = 3.2f,
                    Accuracy = 2f,
                    Cost = 65,
                    IsUnique = false,
                    Image = "5.webp",
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 6,
                    Name = "High Roller Double-Action Revolver",
                    Damage = 1.5f,
                    Range = 2f,
                    FiringRate = 3.2f,
                    Accuracy = 2.8f,
                    Cost = 190,
                    IsUnique = false,
                    Image = "6.webp",
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 7,
                    Name = "M1899 Pistol",
                    Damage = 1.5f,
                    Range = 2f,
                    FiringRate = 3.1f,
                    Accuracy = 3.2f,
                    Cost = 350,
                    IsUnique = false,
                    Image = "7.webp",
                    LocationId = 13
                },
                new Weapon
                {
                    Id = 8,
                    Name = "Evans Repeater",
                    Damage = 2f,
                    Range = 2.6f,
                    FiringRate = 2.6f,
                    Accuracy = 3f,
                    Cost = 140,
                    IsUnique = false,
                    Image = "8.webp",
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 9,
                    Name = "Litchfield Repeater",
                    Damage = 2.8f,
                    Range = 2.8f,
                    FiringRate = 2.2f,
                    Accuracy = 2.7f,
                    Cost = 145,
                    IsUnique = false,
                    Image = "9.webp",
                    LocationId = 1
                },
                new Weapon
                {
                    Id = 10,
                    Name = "Double-barreled Shotgun",
                    Damage = 2.8f,
                    Range = 1.5f,
                    FiringRate = 2.5f,
                    Accuracy = 1.8f,
                    Cost = 95,
                    IsUnique = false,
                    Image = "10.webp",
                    LocationId = 1
                }
            );
        }
    }
}
