using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserFactionConfiguration : IEntityTypeConfiguration<UserFaction>
    {
        public void Configure(EntityTypeBuilder<UserFaction> builder)
        {
            builder.HasKey(k => new { k.UserId, k.FactionId });

            builder.HasData
            (
                new UserFaction
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    FactionId = 1,
                },
                new UserFaction
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    FactionId = 2,
                },
                new UserFaction
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FactionId = 1,
                },
                new UserFaction
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FactionId = 2,
                },
                new UserFaction
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FactionId = 4,
                },
                new UserFaction
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FactionId = 5,
                },
                new UserFaction
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    FactionId = 6,
                },
                new UserFaction
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FactionId = 1,
                },
                new UserFaction
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FactionId = 2,
                },
                new UserFaction
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    FactionId = 3,
                }
            );
        }
    }
}
