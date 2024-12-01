using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.NetworkInformation;

namespace Repository.Configuration
{
    public class UserFishConfiguration : IEntityTypeConfiguration<UserFish>
    {
        public void Configure(EntityTypeBuilder<UserFish> builder)
        {
            builder.HasKey(k => new { k.UserId, k.FishId });

            builder.HasData
            (
                new UserFish
                {
                    UserId = 1,
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = 1,
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = 2,
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = 2,
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = 2,
                    FishId = 4,
                },
                new UserFish
                {
                    UserId = 2,
                    FishId = 5,
                },
                new UserFish
                {
                    UserId = 2,
                    FishId = 6,
                },
                new UserFish
                {
                    UserId = 3,
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = 3,
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = 3,
                    FishId = 3,
                }
            );
        }
    }
}
