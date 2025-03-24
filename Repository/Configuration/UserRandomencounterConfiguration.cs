using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserRandomencounterConfiguration : IEntityTypeConfiguration<UserRandomencounter>
    {
        public void Configure(EntityTypeBuilder<UserRandomencounter> builder)
        {
            builder.HasKey(k => new { k.UserId, k.RandomencounterId });

            builder.HasData
            (
                new UserRandomencounter
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    RandomencounterId = 1,
                },
                new UserRandomencounter
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    RandomencounterId = 2,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 1,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 2,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 3,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 4,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 5,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 6,
                },
                new UserRandomencounter
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    RandomencounterId = 7,
                },
                new UserRandomencounter
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    RandomencounterId = 3,
                }
            );
        }
    }
}
