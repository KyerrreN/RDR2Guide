using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserChallengeConfiguration : IEntityTypeConfiguration<UserChallenge>
    {
        public void Configure(EntityTypeBuilder<UserChallenge> builder)
        {
            builder.HasKey(k => new { k.UserId, k.ChallengeId });

            builder.HasData
            (
                new UserChallenge
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    ChallengeId = 1,
                },
                new UserChallenge
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    ChallengeId = 2,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 1,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 2,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 3,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 4,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 5,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 6,
                },
                new UserChallenge
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    ChallengeId = 7,
                },
                new UserChallenge
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    ChallengeId = 2,
                }
            );
        }
    }
}
