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
                    UserId = 1,
                    RandomencounterId = 1,
                },
                new UserRandomencounter
                {
                    UserId = 1,
                    RandomencounterId = 2,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 1,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 2,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 3,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 4,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 5,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 6,
                },
                new UserRandomencounter
                {
                    UserId = 2,
                    RandomencounterId = 7,
                },
                new UserRandomencounter
                {
                    UserId = 3,
                    RandomencounterId = 3,
                }
            );
        }
    }
}
