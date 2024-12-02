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
                    Image = "sideQuests/1.webp",
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
                    Image = "sideQuests/2.webp",
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
                    Image = "sideQuests/3.webp",
                    LocationId = 1
                },
                new Sidequest
                {
                    Id = 4,
                    Name = "The Noblest of Men, and a Woman",
                    Reward = "Letter from Theodore Levin, $350",
                    QuestGiver = "Theodore Levin",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/4.webp",
                    LocationId = 1
                },
                new Sidequest
                {
                    Id = 5,
                    Name = "The Smell of the Grease Paint",
                    Reward = "Letter from Miss Marjorie, $40",
                    QuestGiver = "Miss Marjorie",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/5.webp",
                    LocationId = 3
                },
                new Sidequest
                {
                    Id = 6,
                    Name = "The Iniquities of History",
                    Reward = "Honor",
                    QuestGiver = "Jeremiah Compson",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/6.webp",
                    LocationId = 5
                },
                new Sidequest
                {
                    Id = 7,
                    Name = "The Ties That Bind Us",
                    Reward = "$40 or Positive Honor",
                    QuestGiver = "Sampson Black & Wendell White",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/7.webp",
                    LocationId = 5
                },
                new Sidequest
                {
                    Id = 8,
                    Name = "He's British, of Course",
                    Reward = "Emerald",
                    QuestGiver = "Margaret",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/8.webp",
                    LocationId = 14
                },
                new Sidequest
                {
                    Id = 9,
                    Name = "The Artist's Way",
                    Reward = "Missable Otis Miller's Revolver",
                    QuestGiver = "Charles Chatenay",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/9.webp",
                    LocationId = 13
                },
                new Sidequest
                {
                    Id = 10,
                    Name = "Duchesses and Other Animals",
                    Reward = "$750, Exotic Hat, Algernon's Revolver",
                    QuestGiver = "Algernon Wasp",
                    IsMissable = false,
                    MissableChapter = null,
                    Image = "sideQuests/10.webp",
                    LocationId = 13
                }
            );
        }
    }
}
