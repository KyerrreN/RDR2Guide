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
                    UserId = 1,
                    SidequestId = 1,
                },
                new UserSidequest
                {
                    UserId = 1,
                    SidequestId = 2,
                },
                new UserSidequest
                {
                    UserId = 2,
                    SidequestId = 1,
                },
                new UserSidequest
                {
                    UserId = 2,
                    SidequestId = 2,
                }
            );
        }
    }
}
