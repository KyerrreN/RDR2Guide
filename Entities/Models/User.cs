using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public string Nickname { get; set; } = null!;

        // RELATIONSHIPS

        // Weapon
        public ICollection<Weapon> Weapons { get; } = [];
        public ICollection<UserWeapon> UserWeapons { get; } = [];

        // Horse
        public ICollection<Horse> Horses { get; } = [];
        public ICollection<UserHorse> UserHorses { get; } = [];

        // Storyquest
        public ICollection<Storyquest> Storyquests { get; } = [];
        public ICollection<UserStoryquest> UserStoryquests { get; } = [];

        // Sidequest
        public ICollection<Sidequest> Sidequests { get; } = [];
        public ICollection<UserSidequest> UserSidequests { get; } = [];

        // Faction
        public ICollection<Faction> Factions { get; } = [];
        public ICollection<UserFaction> UserFactions { get; } = [];

        // Randomencounter
        public ICollection<Randomencounter> Randomencounters { get; } = [];
        public ICollection<UserRandomencounter> UserRandomencounters { get; } = [];

        // Collectible
        public ICollection<Collectible> Collectibles { get; } = [];
        public ICollection<UserCollectible> UserCollectibles { get; } = [];

        // Animal
        public ICollection<Animal> Animals { get; } = [];
        public ICollection<UserAnimal> UserAnimals { get; } = [];

        // Plant
        public ICollection<Plant> Plants { get; } = [];
        public ICollection<UserPlant> UserPlants { get; } = [];

        // Challenge
        public ICollection<Challenge> Challenges { get; } = [];
        public ICollection<UserChallenge> UserChallenges { get;} = [];

        // Tablegame
        public ICollection<Tablegame> Tablegames { get; } = [];
        public ICollection<UserTablegame> UserTablegames { get; } = [];

        // Miscellaneous
        public ICollection<Miscellaneous> Miscellaneous { get; } = [];
        public ICollection<UserMiscellaneous> UserMiscellaneous { get; } = [];

        // Fish
        public ICollection<Fish> Fish { get; } = [];
        public ICollection<UserFish> UserFish { get; } = [];
    }
}
