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
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    HorseId = 5
                },
                new UserHorse
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    HorseId = 1
                },
                new UserHorse
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    HorseId = 2
                },
                new UserHorse
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    HorseId = 3
                },
                new UserHorse
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    HorseId = 4
                },
                new UserHorse
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    HorseId = 5
                }
            );
        }
    }
}
