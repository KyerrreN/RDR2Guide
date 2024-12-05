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
                    Image = "locations/1.webp",
                },
                new Location
                {
                    Id = 2,
                    Name = "Strawberry",
                    Image = "locations/2.webp",
                },
                new Location
                {
                    Id = 3,
                    Name = "New Hanover",
                    Image = "locations/3.webp",
                },
                new Location
                {
                    Id = 4,
                    Name = "West Elizabeth",
                    Image = "locations/4.webp"
                },
                new Location
                {
                    Id = 5,
                    Name = "Scarlett Meadows",
                    Image = "locations/5.webp"
                },
                new Location
                {
                    Id = 6,
                    Name = "Bayou Nwa",
                    Image = "locations/6.webp"
                },
                new Location
                {
                    Id = 7,
                    Name = "Tumbleweed",
                    Image = "locations/7.webp"
                },
                new Location
                {
                    Id = 8,
                    Name = "Blackwater",
                    Image = "locations/8.webp"
                },
                new Location
                {
                    Id = 9,
                    Name = "Colter",
                    Image = "locations/9.webp"
                },
                new Location
                {
                    Id = 10,
                    Name = "Horseshoe Overlook",
                    Image = "locations/10.webp"
                },
                new Location
                {
                    Id = 11,
                    Name = "Cornwall Kerosene&Tar",
                    Image = "locations/11.webp"
                },
                new Location
                {
                    Id = 12,
                    Name = "Ambarino",
                    Image = "locations/12.webp"
                },
                new Location
                {
                    Id = 13,
                    Name = "Saint Denis",
                    Image = "locations/13.webp"
                },
                new Location
                {
                    Id = 14,
                    Name = "Lemoyne",
                    Image = "locations/14.webp"
                },
                new Location
                {
                    Id = 15,
                    Name = "New Austin",
                    Image = "locations/15.webp"
                },
                new Location
                {
                    Id = 16,
                    Name = "Guarma island",
                    Image = "locations/16.webp"
                }
            );
        }
    }
}
