using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class TablegameConfiguration : IEntityTypeConfiguration<Tablegame>
    {
        public void Configure(EntityTypeBuilder<Tablegame> builder)
        {
            // ЗДЕСЬ ВСЕ ЗАПОЛНЕНО
            builder.HasData
            (
                new Tablegame
                {
                    Id = 1,
                    Name = "Poker",
                    Description = "The player can participate in games of poker throughout the game world. Poker is often used as a money-making method, but the process is a risk as you can either lose or earn considerable sums of cash. Saloons prominently feature poker tables.\r\n\r\nThe poker rules used in-game are those from no-limit Texas Hold 'Em. You should have at least a passing understanding of the rules as the game does not tell you all of the information on a winning hand, only the primary information. Winning hands (in order from worst to best) are as follows: High card, 1 pair, 2 pairs, 3 of a kind, straight (five cards in sequence such as 9-10-Jack-Queen-King), flush (5 of one suit), full house (three of a kind plus a pair), four of a kind, straight flush (5 sequential cards of the same suit), royal flush (as with straight flush but 10, Jack, Queen, King, Ace).\r\n\r\nPlayers may use any combination of the two cards they hold and the five community cards to form the best five-card hand. The nature of community-card poker games greatly increases the chance of two or more players each having strong hands, thus increasing the level of action (betting)."
                },
                new Tablegame
                {
                    Id = 2,
                    Name = "Blackjack",
                    Description = "Blackjack is a type of card game, and is traditionally associated with betting and gambling. It is also known colloquially as Twenty-One and Pontoon. In North America during the early twentieth-century time period that Red Dead Redemption is set in, blackjack is a serious parlor game that can sometimes result in violent disputes and death.",
                },
                new Tablegame
                {
                    Id = 3,
                    Name = "Five Finger Fillet",
                    Description = "To play, the player places their hand palm-down on a table with his fingers spread apart. Using a knife, the player attempts to quickly strike the spaces between his fingers, while moving the knife back and forth, attempting to avoid injury. The higher the wager the user chooses the harder the pattern will be. The knife seems to be a larger version of the Throwing Knife.\r\n\r\nThis game is played competitively and cash is wagered on the outcome. The difficulty of the game increases with larger bets.",
                },
                new Tablegame
                {
                    Id = 4,
                    Name = "Dominoes",
                    Description = "The goal is to empty your hand of dominoes first. It is done by placing dominoes with matching pips together. If a domino cannot be played, the player must draw from the \"boneyard\" until a playable domino is drawn. The first person to run out, wins.",
                }
            );
        }
    }
}
