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
    // https://reddead.fandom.com/wiki/Single-player_Challenges_in_Redemption_2
    public class ChallengeConfiguration : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.HasData
            (
                new Challenge
                {
                    Id = 1,
                    Name = "Bandit",
                    Rank = 1,
                    Description = "Hold up 5 townsfolk.",
                    Reward = "Bandit Bandolier"
                },
                new Challenge
                {
                    Id = 2,
                    Name = "Bandit",
                    Rank = 2,
                    Description = "Rob any 2 coaches or return any 2 stolen coaches to the Fence.",
                    Reward = "25 Dead Eye XP, $5.00"
                },
                new Challenge
                {
                    Id = 3,
                    Name = "Gambler",
                    Rank = 1,
                    Description = "Win 5 hands of poker.",
                    Reward = "Gambler Holster"
                },
                new Challenge
                {
                    Id = 4,
                    Name = "Gambler",
                    Rank = 3,
                    Description = "Win 3 gameы of Five Finger Fillet.",
                    Reward = "Gambler Bandolier"
                },
                new Challenge
                {
                    Id = 5,
                    Name = "Survivalist",
                    Rank = 1,
                    Description = "Catch 3 Bluegill fish.",
                    Reward = "Survivalist Gun Belt"
                },
                new Challenge
                {
                    Id = 6,
                    Name = "Explorer",
                    Rank = 1,
                    Description = "Find a treasure map.",
                    Reward = "Explorer Holster"
                },
                new Challenge
                {
                    Id = 7,
                    Name = "Horseman",
                    Rank = 2,
                    Description = "Jump over 3 obstacles in 15 seconds.",
                    Reward = "25 Stamina XP, $5.00"
                },
                new Challenge
                {
                    Id = 8,
                    Name = "Master Hunter",
                    Rank = 3,
                    Description = "Track 10 different animal species using your binoculars.",
                    Reward = "Master Hunter Bandolier"
                },
                new Challenge
                {
                    Id = 9,
                    Name = "Weapons Expert",
                    Rank = 1,
                    Description = "Kill 3 enemies with a knife.",
                    Reward = "Weapons Expert Holster"
                },
                new Challenge
                {
                    Id = 10,
                    Name = "Herbalist",
                    Rank = 9,
                    Description = "Pick one of each species of herb.",
                    Reward = "150 Health XP, $20.00"
                }
            );
        }
    }
}
