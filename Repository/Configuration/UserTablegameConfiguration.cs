using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserTablegameConfiguration : IEntityTypeConfiguration<UserTablegame>
    {
        public void Configure(EntityTypeBuilder<UserTablegame> builder)
        {
            builder.HasKey(k => new { k.UserId, k.TablegameId });

            builder.HasData
            (
                new UserTablegame
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    TablegameId = 3,
                },
                new UserTablegame
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    TablegameId = 4,
                },
                new UserTablegame
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    TablegameId = 3,
                },
                new UserTablegame
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    TablegameId = 3,
                }
            );
        }
    }
}
