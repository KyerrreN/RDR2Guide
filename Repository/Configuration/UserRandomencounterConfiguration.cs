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
                }
            );
        }
    }
}
