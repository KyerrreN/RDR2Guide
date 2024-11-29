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
                    UserId = 1,
                    WeaponId = 1,
                },
                new UserWeapon
                {
                    UserId = 1,
                    WeaponId = 2,
                },
                new UserWeapon
                {
                    UserId = 2,
                    WeaponId = 1,
                }, new UserWeapon
                {
                    UserId = 2,
                    WeaponId = 2,
                }
            );
        }
    }
}
