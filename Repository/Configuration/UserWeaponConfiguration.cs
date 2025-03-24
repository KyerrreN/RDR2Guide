using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserWeaponConfiguration : IEntityTypeConfiguration<UserWeapon>
    {
        public void Configure(EntityTypeBuilder<UserWeapon> builder)
        {
            builder.HasKey(k => new { k.UserId, k.WeaponId });

            builder.HasData
            (
                new UserWeapon
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    WeaponId = 1,
                },
                new UserWeapon
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    WeaponId = 2,
                },
                new UserWeapon
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    WeaponId = 1,
                },
                new UserWeapon
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    WeaponId = 2,
                },
                new UserWeapon
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    WeaponId = 3,
                },
                new UserWeapon
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    WeaponId = 4,
                },
                new UserWeapon
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    WeaponId = 5,
                },
                new UserWeapon
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    WeaponId = 1,
                },
                new UserWeapon
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    WeaponId = 2,
                },
                new UserWeapon
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    WeaponId = 3,
                }
            );
        }
    }
}
