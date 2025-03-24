using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserMiscellaneousConfiguration : IEntityTypeConfiguration<UserMiscellaneous>
    {
        public void Configure(EntityTypeBuilder<UserMiscellaneous> builder)
        {
            builder.HasKey(k => new { k.UserId, k.MiscellaneousId });

            builder.HasData
            (
                new UserMiscellaneous
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    MiscellaneousId = 1,
                },
                new UserMiscellaneous
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    MiscellaneousId = 2,
                },
                new UserMiscellaneous
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    MiscellaneousId = 1,
                },
                new UserMiscellaneous
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    MiscellaneousId = 2,
                },
                new UserMiscellaneous
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    MiscellaneousId = 3,
                },
                new UserMiscellaneous
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    MiscellaneousId = 4,
                },
                new UserMiscellaneous
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    MiscellaneousId = 1,
                },
                new UserMiscellaneous
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    MiscellaneousId = 2,
                },
                new UserMiscellaneous
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    MiscellaneousId = 3,
                },
                new UserMiscellaneous
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    MiscellaneousId = 4,
                }
            );
        }
    }
}
