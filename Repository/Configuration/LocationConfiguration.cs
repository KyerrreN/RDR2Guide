using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData
            (
                new Location
                {
                    Id = 1,
                    Name = "Valentine",
                    Image = null,
                },
                new Location
                {
                    Id = 2,
                    Name = "Strawberry",
                    Image = null,
                },
                new Location
                {
                    Id = 3,
                    Name = "New Hanover",
                    Image = null,
                },
                new Location
                {
                    Id = 4,
                    Name = "West Elizabeth",
                    Image = null
                },
                new Location
                {
                    Id = 5,
                    Name = "Scarlett Meadows",
                    Image = null
                },
                new Location
                {
                    Id = 6,
                    Name = "Bayou Nwa",
                    Image = null
                },
                new Location
                {
                    Id = 7,
                    Name = "Tumbleweed",
                    Image = null
                },
                new Location
                {
                    Id = 8,
                    Name = "Blackwater",
                    Image = null
                },
                new Location
                {
                    Id = 9,
                    Name = "Colter",
                    Image = null
                },
                new Location
                {
                    Id = 10,
                    Name = "Horseshoe Overlook",
                    Image = null
                },
                new Location
                {
                    Id = 11,
                    Name = "Cornwall Kerosene&Tar",
                    Image = null
                },
                new Location
                {
                    Id = 12,
                    Name = "Ambarino",
                    Image = null
                },
                new Location
                {
                    Id = 13,
                    Name = "Saint Denis",
                    Image = null
                },
                new Location
                {
                    Id = 14,
                    Name = "Lemoyne",
                    Image = null
                },
                new Location
                {
                    Id = 15,
                    Name = "New Austin",
                    Image = null
                },
                new Location
                {
                    Id = 16,
                    Name = "Guarma island",
                    Image = null
                }
            );
        }
    }
}
