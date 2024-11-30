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
                    UserId = 1,
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = 1,
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = 2,
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = 2,
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = 2,
                    TablegameId = 3,
                },
                new UserTablegame
                {
                    UserId = 2,
                    TablegameId = 4,
                },
                new UserTablegame
                {
                    UserId = 2,
                    TablegameId = 5,
                },
                new UserTablegame
                {
                    UserId = 3,
                    TablegameId = 1,
                },
                new UserTablegame
                {
                    UserId = 3,
                    TablegameId = 2,
                },
                new UserTablegame
                {
                    UserId = 3,
                    TablegameId = 3,
                }
            );
        }
    }
}
