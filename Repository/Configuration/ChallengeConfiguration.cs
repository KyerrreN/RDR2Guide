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
                }
            );
        }
    }
}
