using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAnimalRepository Animal { get; }
        IChallengeRepository Challenge { get; }
        ICollectibleRepository Collectible { get; }
        IFactionRepository Faction { get; }
        IFishRepository Fish { get; }
        IHorseRepository Horse { get; }
        ILocationRepository Location { get; }
        IMiscellaneousRepository Miscellaneous { get; }
        IPlantRepository Plant { get; }
        IRandomencounterRepository Randomencounter { get; }
        ISidequestRepository Sidequest { get; }
        IStoryquestRepository Storyquest { get; }
        ITablegameRepository Tablegame { get; }
        IUserAnimalRepository UserAnimal { get; }
        IUserChallengeRepository UserChallenge { get; }
        IUserCollectibleRepository UserCollectible {  get; }
        IUserFactionRepository UserFaction { get; }
        IUserFishRepository UserFish { get; }
        IUserHorseRepository UserHorse { get; }
        IUserMiscellaneousRepository UserMiscellaneous { get; }
        IUserPlantRepository UserPlant { get; }
        IUserRandomencounterRepository UserRandomencounter { get; }
        IUserRepository User { get; }   
        IUserSidequestRepository UserSidequest { get; }
        IUserStoryquestRepository UserStoryquest { get; }
        IUserTablegameRepository UserTablegame { get; }
        IUserWeaponRepository UserWeapon { get; }
        IWeaponRepository Weapon { get; }
    }
}
