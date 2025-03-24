using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            PasswordHasher<User> passwordHasher = new();

            User[] data =
            [
                new User
                {
                    Id = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    Nickname = "Vadim123",
                    UserName = "Vadim123",
                    NormalizedUserName = "VADIM123",
                    ConcurrencyStamp = "e78cdca8-703d-4993-aff8-6c722bb80609"
                },
                new User
                {
                    Id = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    Nickname = "Anton123",
                    UserName = "Anton123",
                    NormalizedUserName = "ANTON123",
                    ConcurrencyStamp = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                },
                new User
                {
                    Id = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    Nickname = "Arthur123",
                    UserName = "Arthur123",
                    NormalizedUserName = "ARTHUR123",
                    ConcurrencyStamp = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                }
            ];

            data[0].PasswordHash = passwordHasher.HashPassword(data[0], "Vadim123");
            data[1].PasswordHash = passwordHasher.HashPassword(data[1], "Anton123");
            data[2].PasswordHash = passwordHasher.HashPassword(data[2], "Arthur123");
            // ЗДЕСЬ НИЧЕГО НЕ ЗАПОЛНЯЙ 
            // ok
            builder.HasData(data);
            //builder.HasData
            //(
            //    new User
            //    {
            //        Id = 1,
            //    },
            //    new User
            //    {
            //        Id = 2,
            //    },
            //    new User
            //    {
            //        Id = 3,
            //    },
            //    new User
            //    {
            //        Id = 4,
            //    },
            //    new User
            //    {
            //        Id = 5,
            //    }
            //);
        }
    }
}
