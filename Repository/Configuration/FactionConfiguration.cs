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
    public class FactionConfiguration : IEntityTypeConfiguration<Faction>
    {
        public void Configure(EntityTypeBuilder<Faction> builder)
        {
            builder.HasData
            (
                new Faction
                {
                    Id = 1,
                    Name = "O'Driscoll Boys",
                    Leader = "Colm O'Driscoll",
                    Status = "Disbanded"
                },
                new Faction
                {
                    Id = 2,
                    Name = "Lemoyne Raiders",
                    Leader = "Lindsey Wofford",
                    Status = "Active"
                },
                new Faction
                {
                    Id = 3,
                    Name = "Skinner Brothers",
                    Leader = "Otis Skinner",
                    Status = "Active"
                },
                new Faction
                {
                    Id = 4,
                    Name = "Murfree Brood",
                    Leader = "Walt Murfree",
                    Status = "Active"
                },
                new Faction
                {
                    Id = 5,
                    Name = "Laramie Gang",
                    Leader = "Laramie Gang Leader",
                    Status = "Active"
                },
                new Faction
                {
                    Id = 6,
                    Name = "Del Lobo Gang",
                    Leader = "Esteban Cortez",
                    Status = "Active"
                }
            );
        }
    }
}
