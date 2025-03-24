using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserCollectibleConfiguration : IEntityTypeConfiguration<UserCollectible>
    {
        public void Configure(EntityTypeBuilder<UserCollectible> builder)
        {
            builder.HasKey(k => new { k.UserId, k.CollectibleId });

            builder.HasData
            (
                new UserCollectible
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = "e78cdca8-703d-4993-aff8-6c722bb80609",
                    CollectibleId = 2
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 2
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 3
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 4
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 5
                },
                new UserCollectible
                {
                    UserId = "40f7db0b-5cad-4cae-b82e-b4263eb90c40",
                    CollectibleId = 6
                },
                new UserCollectible
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = "d3c2cf7b-0328-41db-8f5b-c381f0a7bf16",
                    CollectibleId = 2
                }
            );
        }
    }
}
