﻿using Entities.Models;
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
                    UserId = 1,
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = 1,
                    CollectibleId = 2
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 2
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 3
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 4
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 5
                },
                new UserCollectible
                {
                    UserId = 2,
                    CollectibleId = 6
                },
                new UserCollectible
                {
                    UserId = 3,
                    CollectibleId = 1
                },
                new UserCollectible
                {
                    UserId = 3,
                    CollectibleId = 2
                }
            );
        }
    }
}
