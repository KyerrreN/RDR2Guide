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
                    UserId = 1,
                    MiscellaneousId = 1,
                },
                new UserMiscellaneous
                {
                    UserId = 1,
                    MiscellaneousId = 2,
                },
                new UserMiscellaneous
                {
                    UserId = 2,
                    MiscellaneousId = 1,
                },
                new UserMiscellaneous
                {
                    UserId = 2,
                    MiscellaneousId = 2,
                }
            );
        }
    }
}
