using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserHorseConfiguration : IEntityTypeConfiguration<UserHorse>
    {
        public void Configure(EntityTypeBuilder<UserHorse> builder)
        {
            builder.HasKey(k => new { k.UserId, k.HorseId});

            builder.HasData
            (
                new UserHorse
                {
                    UserId = 1,
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = 1,
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = 2,
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = 2,
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = 2,
                    HorseId = 5
                },
                new UserHorse
                {
                    UserId = 3,
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = 3,
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = 3,
                    HorseId = 3
                },
                new UserHorse
                {
                    UserId = 3,
                    HorseId = 4
                },
                new UserHorse
                {
                    UserId = 3,
                    HorseId = 5
                }
            );
        }
    }
}
