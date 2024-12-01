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
                    Image = "1.webp",
                },
                new Location
                {
                    Id = 2,
                    Name = "Strawberry",
                    Image = "2.webp",
                },
                new Location
                {
                    Id = 3,
                    Name = "New Hanover",
                    Image = "3.webp",
                },
                new Location
                {
                    Id = 4,
                    Name = "West Elizabeth",
                    Image = "4.webp"
                },
                new Location
                {
                    Id = 5,
                    Name = "Scarlett Meadows",
                    Image = "5.webp"
                },
                new Location
                {
                    Id = 6,
                    Name = "Bayou Nwa",
                    Image = "6.webp"
                },
                new Location
                {
                    Id = 7,
                    Name = "Tumbleweed",
                    Image = "7.webp"
                },
                new Location
                {
                    Id = 8,
                    Name = "Blackwater",
                    Image = "8.webp"
                },
                new Location
                {
                    Id = 9,
                    Name = "Colter",
                    Image = "9.webp"
                },
                new Location
                {
                    Id = 10,
                    Name = "Horseshoe Overlook",
                    Image = "10.webp"
                },
                new Location
                {
                    Id = 11,
                    Name = "Cornwall Kerosene&Tar",
                    Image = "11.webp"
                },
                new Location
                {
                    Id = 12,
                    Name = "Ambarino",
                    Image = "12.webp"
                },
                new Location
                {
                    Id = 13,
                    Name = "Saint Denis",
                    Image = "13.webp"
                },
                new Location
                {
                    Id = 14,
                    Name = "Lemoyne",
                    Image = "14.webp"
                },
                new Location
                {
                    Id = 15,
                    Name = "New Austin",
                    Image = "15.webp"
                },
                new Location
                {
                    Id = 16,
                    Name = "Guarma island",
                    Image = "16.webp"
                }
            );
        }
    }
}
