using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RandomencounterConfiguration : IEntityTypeConfiguration<Randomencounter>
    {
        public void Configure(EntityTypeBuilder<Randomencounter> builder)
        {
            builder.HasData
            (
                new Randomencounter
                {
                    Id = 1,
                    Name = "Stagecoach Robbery",
                    FactionId = 1,
                },
                new Randomencounter
                {
                    Id = 2,
                    Name = "Gatling Gun Ambush",
                    FactionId = 2
                },
                new Randomencounter
                {
                    Id = 3,
                    Name = "Abducted Policeman",
                    FactionId = 2
                }
            );
        }
    }
}
