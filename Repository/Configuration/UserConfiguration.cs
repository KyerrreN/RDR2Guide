using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // ЗДЕСЬ НИЧЕГО НЕ ЗАПОЛНЯЙ
            builder.HasData
            (
                new User
                {
                    Id = 1,
                },
                new User
                {
                    Id = 2,
                },
                new User
                {
                    Id = 3,
                },
                new User
                {
                    Id = 4,
                },
                new User
                {
                    Id = 5,
                }
            );
        }
    }
}
