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
                    Name = "Kill any 5 Legendary Animals."
                },
                new Miscellaneous
                {
                    Id = 2,
                    Name = "Play each table game at least once."
                },
                new Miscellaneous
                {
                    Id = 3,
                    Name = "Take a bath at least once. (Available in hotels)"
                }
            );
        }
    }
}
