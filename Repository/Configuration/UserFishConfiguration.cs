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
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FishId = 4,
                },
                new UserFish
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FishId = 5,
                },
                new UserFish
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FishId = 6,
                },
                new UserFish
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FishId = 1,
                },
                new UserFish
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FishId = 2,
                },
                new UserFish
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FishId = 3,
                }
            );
        }
    }
}
