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
                    UserId = 1,
                    AnimalId = 1,
                },
                new UserAnimal
                {
                    UserId = 1,
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 1,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 3,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 4,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 5,
                },
                new UserAnimal
                {
                    UserId = 2,
                    AnimalId = 6,
                },
                new UserAnimal
                {
                    UserId = 3,
                    AnimalId = 2,
                },
                new UserAnimal
                {
                    UserId = 3,
                    AnimalId = 5,
                }
            );
        }
    }
}
