using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAnimalService> _animalService;
        private readonly Lazy<IChallengeService> _challengeService;
        private readonly Lazy<ICollectibleService> _collectibleService;
        private readonly Lazy<IFactionService> _factionService;
        private readonly Lazy<IFishService> _fishService;
        private readonly Lazy<IHorseService> _horseService;
        private readonly Lazy<ILocationService> _locationService;
        private readonly Lazy<IMiscellaneousService> _miscellaneousService;
        private readonly Lazy<IPlantService> _plantService;
        private readonly Lazy<IRandomEncounterService> _randomEncounterService;
        private readonly Lazy<ISidequestService> _sidequestService;
        private readonly Lazy<IStoryquestService> _storyquestService;
        private readonly Lazy<ITablegameService> _tablegameService;
        private readonly Lazy<IUserAnimalService> _userAnimalService;
        private readonly Lazy<IUserChallengeService> _userChallengeService;
        private readonly Lazy<IUserCollectibleService> _userCollectibleService;
        private readonly Lazy<IUserFactionService> _userFactionService;
        private readonly Lazy<IUserFishService> _userFishService;
        private readonly Lazy<IUserHorseService> _userHorseService;
        private readonly Lazy<IUserMiscellaneousService> _userMiscellaneousService;
        private readonly Lazy<IUserPlantService> _userPlantService;
        private readonly Lazy<IUserRandomencounterService> _userRandomencounterService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IUserSidequestService> _userSidequestService;
        private readonly Lazy<IUserStoryquestService> _userStoryquestService;
        private readonly Lazy<IUserTablegameService> _userTablegameService;
        private readonly Lazy<IUserWeaponService> _userWeaponService;
        private readonly Lazy<IWeaponService> _weaponService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager,
                              IMapper mapper,
                              UserManager<User> userManager,
                              IConfiguration configuration,
                              RoleManager<IdentityRole> roleManager)
        {
            _animalService = new Lazy<IAnimalService>(() => new AnimalService(repositoryManager, mapper));
            _challengeService = new Lazy<IChallengeService>(() => new ChallengeService(repositoryManager, mapper));
            _collectibleService = new Lazy<ICollectibleService>(() => new CollectibleService(repositoryManager, mapper));
            _factionService = new Lazy<IFactionService>(() => new FactionService(repositoryManager, mapper));
            _fishService = new Lazy<IFishService>(() => new FishService(repositoryManager, mapper));
            _horseService = new Lazy<IHorseService>(() => new HorseService(repositoryManager, mapper));
            _locationService = new Lazy<ILocationService>(() => new LocationService(repositoryManager, mapper));
            _miscellaneousService = new Lazy<IMiscellaneousService>(() => new MiscellaneousService(repositoryManager, mapper));
            _plantService = new Lazy<IPlantService>(() => new PlantService(repositoryManager, mapper));
            _randomEncounterService = new Lazy<IRandomEncounterService>(() => new RandomEncounterService(repositoryManager, mapper));
            _sidequestService = new Lazy<ISidequestService>(() => new SidequestService(repositoryManager, mapper));
            _storyquestService = new Lazy<IStoryquestService>(() => new StoryquestService(repositoryManager, mapper));
            _tablegameService = new Lazy<ITablegameService>(() => new TablegameService(repositoryManager, mapper));
            _userAnimalService = new Lazy<IUserAnimalService>(() => new UserAnimalService(repositoryManager, mapper));
            _userChallengeService = new Lazy<IUserChallengeService>(() => new UserChallengeService(repositoryManager, mapper));
            _userCollectibleService = new Lazy<IUserCollectibleService>(() => new UserCollectibleService(repositoryManager, mapper));
            _userFactionService = new Lazy<IUserFactionService>(() => new UserFactionService(repositoryManager, mapper));
            _userFishService = new Lazy<IUserFishService>(() => new UserFishService(repositoryManager, mapper));
            _userHorseService = new Lazy<IUserHorseService>(() => new UserHorseService(repositoryManager, mapper));
            _userMiscellaneousService = new Lazy<IUserMiscellaneousService>(() => new UserMiscellaneousService(repositoryManager, mapper));
            _userPlantService = new Lazy<IUserPlantService>(() => new UserPlantService(repositoryManager, mapper));
            _userRandomencounterService = new Lazy<IUserRandomencounterService>(() => new UserRandomEncounterService(repositoryManager, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper));
            _userSidequestService = new Lazy<IUserSidequestService>(() => new UserSidequestService(repositoryManager, mapper));
            _userStoryquestService = new Lazy<IUserStoryquestService>(() => new UserStoryquestService(repositoryManager, mapper));
            _userTablegameService = new Lazy<IUserTablegameService>(() => new UserTablegameService(repositoryManager, mapper));
            _userWeaponService = new Lazy<IUserWeaponService>(() => new UserWeaponService(repositoryManager, mapper));
            _weaponService = new Lazy<IWeaponService>(() => new WeaponService(repositoryManager, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, configuration, mapper, roleManager));
        }



        public IAnimalService AnimalService => _animalService.Value;

        public IChallengeService ChallengeService => _challengeService.Value;

        public ICollectibleService CollectibleService => _collectibleService.Value;

        public IFactionService FactionService => _factionService.Value;

        public IFishService FishService => _fishService.Value;

        public IHorseService HorseService => _horseService.Value;

        public ILocationService LocationService => _locationService.Value;

        public IMiscellaneousService MiscellaneousService => _miscellaneousService.Value;

        public IPlantService PlantService => _plantService.Value;

        public IRandomEncounterService RandomEncounterService => _randomEncounterService.Value;

        public ISidequestService SidequestService => _sidequestService.Value;

        public IStoryquestService StoryquestService => _storyquestService.Value;

        public ITablegameService TablegameService => _tablegameService.Value;

        public IUserAnimalService UserAnimalService => _userAnimalService.Value;

        public IUserChallengeService UserChallengeService => _userChallengeService.Value;

        public IUserCollectibleService UserCollectibleService => _userCollectibleService.Value;

        public IUserFactionService UserFactionService => _userFactionService.Value;

        public IUserFishService UserFishService => _userFishService.Value;

        public IUserHorseService UserHorseService => _userHorseService.Value;

        public IUserMiscellaneousService UserMiscellaneousService => _userMiscellaneousService.Value;

        public IUserPlantService UserPlantService => _userPlantService.Value;

        public IUserRandomencounterService UserRandomencounterService => _userRandomencounterService.Value;

        public IUserService UserService => _userService.Value;

        public IUserSidequestService UserSidequestService => _userSidequestService.Value;

        public IUserStoryquestService UserStoryquestService => _userStoryquestService.Value;

        public IUserTablegameService UserTablegameService => _userTablegameService.Value;

        public IUserWeaponService UserWeaponService => _userWeaponService.Value;

        public IWeaponService WeaponService => _weaponService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
