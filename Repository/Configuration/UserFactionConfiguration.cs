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
                    UserId = 1,
                    FactionId = 1,
                },
                new UserFaction
                {
                    UserId = 1,
                    FactionId = 2,
                },
                new UserFaction
                {
                    UserId = 2,
                    FactionId = 1,
                },
                new UserFaction
                {
                    UserId = 2,
                    FactionId = 2,
                }
            );
        }
    }
}
