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
                    Name = "Arson and Vandalism at the Saint Denis City Hall",
                    FactionId = 2
                },
                new Randomencounter
                {
                    Id = 4,
                    Name = "Camp Intimidation",
                    FactionId = 4
                },
                new Randomencounter
                {
                    Id = 5,
                    Name = "Burning Wagon Attack",
                    FactionId = 4
                },
                new Randomencounter
                {
                    Id = 6,
                    Name = "Hostage Situation",
                    FactionId = 5
                },
                new Randomencounter
                {
                    Id = 7,
                    Name = "Venter's Place Party",
                    FactionId = 6
                },
                new Randomencounter
                {
                    Id = 8,
                    Name = "Del Lobo Breakout",
                    FactionId = 6
                },
                new Randomencounter
                {
                    Id = 9,
                    Name = "Train Robbery",
                    FactionId = 1
                },
                new Randomencounter
                {
                    Id = 10,
                    Name = "Prison Wagon Break",
                    FactionId = 1
                }
            );
        }
    }
}
