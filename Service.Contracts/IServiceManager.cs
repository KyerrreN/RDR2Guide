using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IAnimalService AnimalService { get; } //
        IChallengeService ChallengeService { get; } //
        ICollectibleService CollectibleService { get; } //
        IFactionService FactionService { get; } //
        IFishService FishService { get; } //
        IHorseService HorseService { get; } //
        ILocationService LocationService { get; } //
        IMiscellaneousService MiscellaneousService { get; } //
        IPlantService PlantService { get; } //
        IRandomEncounterService RandomEncounterService { get; } //
        ISidequestService SidequestService { get; } //
        IStoryquestService StoryquestService { get; } //
        ITablegameService TablegameService { get; } //
        IUserAnimalService UserAnimalService { get; } //
        IUserChallengeService UserChallengeService { get; } //
        IUserCollectibleService UserCollectibleService { get; } //
        IUserFactionService UserFactionService { get; } //
        IUserFishService UserFishService { get; } //
        IUserHorseService UserHorseService { get; } //
        IUserMiscellaneousService UserMiscellaneousService { get; } //
        IUserPlantService UserPlantService { get; } //
        IUserRandomencounterService UserRandomencounterService { get; } //
        IUserService UserService { get; } //
        IUserSidequestService UserSidequestService { get; } //
        IUserStoryquestService UserStoryquestService { get; } //
        IUserTablegameService UserTablegameService { get; } //
        IUserWeaponService UserWeaponService { get; } //
        IWeaponService WeaponService { get; } //
        IAuthenticationService AuthenticationService { get; }
    }
}
