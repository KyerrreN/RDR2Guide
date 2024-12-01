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
    internal class MiscellaneousConfiguration : IEntityTypeConfiguration<Miscellaneous>
    {
        public void Configure(EntityTypeBuilder<Miscellaneous> builder)
        {
            builder.HasData
            (
                new Miscellaneous
                {
                    Id = 1,
                    Name = "Investigate any 5 shacks."
                },
                new Miscellaneous
                {
                    Id = 2,
                    Name = "Kill any 5 Legendary Animals."
                },
                new Miscellaneous
                {
                    Id = 3,
                    Name = "Play each table game at least once."
                },
                new Miscellaneous
                {
                    Id = 4,
                    Name = "Interact with 5 special characters."
                },
                new Miscellaneous
                {
                    Id = 5,
                    Name = "Take a bath at least once. (Available in hotels)"
                },
                new Miscellaneous
                {
                    Id = 6,
                    Name = "Watch a show."
                },
                new Miscellaneous
                {
                    Id = 7,
                    Name = "Watch a live show at the Theater."
                },
                new Miscellaneous
                {
                    Id = 8,
                    Name = "Craft 1 recipe from six different category types."
                },
                new Miscellaneous
                {
                    Id = 9,
                    Name = "Complete a Home Robbery, a Shop Robbery, a Coach Robbery and a Train Robbery."
                }
            );
        }
    }
}
