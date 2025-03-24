using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserSidequestConfiguration : IEntityTypeConfiguration<UserSidequest>
    {
        public void Configure(EntityTypeBuilder<UserSidequest> builder)
        {
            builder.HasKey(k => new { k.UserId, k.SidequestId });

            builder.HasData
            (
                new UserSidequest
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    SidequestId = 1,
                },
                new UserSidequest
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    SidequestId = 2,
                },
                new UserSidequest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    SidequestId = 1,
                },
                new UserSidequest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    SidequestId = 2,
                },
                new UserSidequest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    SidequestId = 3,
                },
                new UserSidequest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    SidequestId = 4,
                },
                new UserSidequest
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    SidequestId = 5,
                },
                new UserSidequest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    SidequestId = 1,
                },
                new UserSidequest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    SidequestId = 2,
                },
                new UserSidequest
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    SidequestId = 3,
                }
            );
        }
    }
}
