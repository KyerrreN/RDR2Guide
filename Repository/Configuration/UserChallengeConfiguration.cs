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
                    UserId = 1,
                    ChallengeId = 1,
                },
                new UserChallenge
                {
                    UserId = 1,
                    ChallengeId = 2,
                },
                new UserChallenge
                {
                    UserId = 2,
                    ChallengeId = 1,
                },
                new UserChallenge
                {
                    UserId = 2,
                    ChallengeId = 2,
                }
            );
        }
    }
}
