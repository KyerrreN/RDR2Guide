using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class SidequestConfiguration : IEntityTypeConfiguration<Sidequest>
    {
        public void Configure(EntityTypeBuilder<Sidequest> builder)
        {
            builder.HasData
            (
                new Sidequest
                {
                    Id = 1,
                    Name = "Smoking and other Hobbies",
                    Reward = "Vintage Civil War Handcuffs",
                    QuestGiver = "Phineas T. Ramsbottom",
                    IsMissable= false,
                    MissableChapter = null,
                    Image = null,
                    LocationId = 1
                },
                new Sidequest
                {
                    Id = 2,
                    Name = "Geology for Beginners",
                    Reward = "Rock Statue",
                    QuestGiver = "Francis Sinclair",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = null,
                    LocationId = 2
                },
                new Sidequest
                {
                    Id = 3,
                    Name = "A Test of Faith",
                    Reward = "Quartz Chunk",
                    QuestGiver = "Deborah MacGuiness",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = null,
                    LocationId = 1
                }
            );
        }
    }
}
