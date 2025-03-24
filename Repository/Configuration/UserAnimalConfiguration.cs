using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserAnimalConfiguration : IEntityTypeConfiguration<UserAnimal>
    {
        public void Configure(EntityTypeBuilder<UserAnimal> builder)
        {
            builder.HasKey(k => new { k.UserId, k.AnimalId });

            builder.HasData
            (
                new UserAnimal
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    AnimalId = 1,
                },
                new UserAnimal
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 1,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 3,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 4,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 5,
                },
                new UserAnimal
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    AnimalId = 6,
                },
                new UserAnimal
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    AnimalId = 5,
                }
            );
        }
    }
}
