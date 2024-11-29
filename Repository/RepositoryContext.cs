using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
            
        }

        // Db Sets
        public DbSet<User>? Users { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Weapon>? Weapons { get; set; }
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Challenge>? Challenges { get; set; }
        public DbSet<Sidequest>? Sidequests { get; set; }
        public DbSet<Collectible>? Collectibles { get; set; }
        public DbSet<Faction>? Factions { get; set; }
        public DbSet<Fish>? Fish { get; set; }
        public DbSet<Horse>? Horses { get; set; }
        public DbSet<Miscellaneous>? Miscellaneous { get; set; }
        public DbSet<Plant>? Plants { get; set; }
        public DbSet<Randomencounter>? Randomencounters { get; set; }
        public DbSet<Storyquest>? Storyquests { get; set; }
        public DbSet<Tablegame>? Tablegames { get; set; }
        public DbSet<UserAnimal>? UserAnimals { get; set; }
        public DbSet<UserChallenge>? UserChallenges { get; set; }
        public DbSet<UserCollectible>? UserCollectibles { get; set; }
        public DbSet<UserFaction>? UserFactions { get; set; }
        public DbSet<UserFish>? UserFish { get; set; }
        public DbSet<UserHorse>? UserHorses { get; set; }
        public DbSet<UserMiscellaneous>? UserMiscellaneous { get; set; }
        public DbSet<UserPlant>? UserPlants { get; set; }
        public DbSet<UserRandomencounter>? UserRandomencounters { get; set; }
        public DbSet<UserSidequest>? UserSidequests { get; set; }
        public DbSet<UserStoryquest>? UserStoryquests { get; set; }
        public DbSet<UserTablegame>? UserTablegames { get; set; }
        public DbSet<UserWeapon>? UserWeapons { get; set; }

        // On Model Creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
