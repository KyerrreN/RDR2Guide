using Contracts;
using Repository.Custom;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _animalRepository = new Lazy<IAnimalRepository>(() => new AnimalRepository(context));
            _challengeRepository = new Lazy<IChallengeRepository>(() => new ChallengeRepository(context));
            _collectibleRepository = new Lazy<ICollectibleRepository>(() => new CollectibleRepository(context));
            _factionRepository = new Lazy<IFactionRepository>(() => new FactionRepository(context));
            _fishRepository = new Lazy<IFishRepository>(() => new FishRepository(context));
            _horseRepository = new Lazy<IHorseRepository>(() => new HorseRepository(context));
            _locationRepository = new Lazy<ILocationRepository>(() => new LocationRepository(context));
            _miscellaneousRepository = new Lazy<IMiscellaneousRepository>(() => new MiscellaneousRepository(context));
            _plantRepository = new Lazy<IPlantRepository>(() => new PlantRepository(context));
            _randomencounterRepository = new Lazy<IRandomencounterRepository>(() => new RandomencounterRepository(context));
            _sidequestRepository = new Lazy<ISidequestRepository>(() => new SidequestRepository(context));
            _storyquestRepository = new Lazy<IStoryquestRepository>(() => new StoryquestRepository(context));
            _tablegameRepository = new Lazy<ITablegameRepository>(() => new TablegameRepository(context));
            _userAnimalRepository = new Lazy<IUserAnimalRepository>(() => new UserAnimalRepository(context));
            _userChallengeRepository = new Lazy<IUserChallengeRepository>(() => new UserChallengeRepository(context));
            _userFactionRepository = new Lazy<IUserFactionRepository>(() => new UserFactionRepository(context));
            _userCollectibleRepository = new Lazy<IUserCollectibleRepository>(() => new UserCollectibleRepository(context));
            _userFishRepository = new Lazy<IUserFishRepository>(() => new UserFishRepository(context));
            _userHorseRepository = new Lazy<IUserHorseRepository>(() => new UserHorseRepository(context));
            _userMiscellaneousRepository = new Lazy<IUserMiscellaneousRepository>(() => new UserMiscellaneousRepository(context));
            _userPlantRepository = new Lazy<IUserPlantRepository>(() => new UserPlantRepository(context));
            _userRandomencounterRepository = new Lazy<IUserRandomencounterRepository>(() => new UserRandomencounterRepository(context));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _userSidequestRepository = new Lazy<IUserSidequestRepository>(() => new UserSidequestRepository(context));
            _userStoryquestRepository = new Lazy<IUserStoryquestRepository>(() => new UserStoryquestRepository(context));
            _userTablegameRepository = new Lazy<IUserTablegameRepository>(() => new UserTablegameRepository(context));
            _userWeaponRepository = new Lazy<IUserWeaponRepository>(() => new UserWeaponRepository(context));
            _weaponRepository = new Lazy<IWeaponRepository>(() => new WeaponRepository(context));
        }

        private readonly Lazy<IAnimalRepository> _animalRepository;//
        private readonly Lazy<IChallengeRepository> _challengeRepository;//
        private readonly Lazy<ICollectibleRepository> _collectibleRepository;//
        private readonly Lazy<IFactionRepository> _factionRepository; //
        private readonly Lazy<IFishRepository> _fishRepository; //
        private readonly Lazy<IHorseRepository> _horseRepository;//
        private readonly Lazy<ILocationRepository> _locationRepository;//
        private readonly Lazy<IMiscellaneousRepository> _miscellaneousRepository;//
        private readonly Lazy<IPlantRepository> _plantRepository; //
        private readonly Lazy<IRandomencounterRepository> _randomencounterRepository;//
        private readonly Lazy<ISidequestRepository> _sidequestRepository; //
        private readonly Lazy<IStoryquestRepository> _storyquestRepository; //
        private readonly Lazy<ITablegameRepository> _tablegameRepository; //
        private readonly Lazy<IUserAnimalRepository> _userAnimalRepository; //
        private readonly Lazy<IUserChallengeRepository> _userChallengeRepository; //
        private readonly Lazy<IUserFactionRepository> _userFactionRepository; //
        private readonly Lazy<IUserCollectibleRepository> _userCollectibleRepository; //
        private readonly Lazy<IUserFishRepository> _userFishRepository; //
        private readonly Lazy<IUserHorseRepository> _userHorseRepository; //
        private readonly Lazy<IUserMiscellaneousRepository> _userMiscellaneousRepository; //
        private readonly Lazy<IUserPlantRepository> _userPlantRepository; //
        private readonly Lazy<IUserRandomencounterRepository> _userRandomencounterRepository; //
        private readonly Lazy<IUserRepository> _userRepository;// 
        private readonly Lazy<IUserSidequestRepository> _userSidequestRepository; //
        private readonly Lazy<IUserStoryquestRepository> _userStoryquestRepository; //
        private readonly Lazy<IUserTablegameRepository> _userTablegameRepository;//
        private readonly Lazy<IUserWeaponRepository> _userWeaponRepository; //
        private readonly Lazy<IWeaponRepository> _weaponRepository; //

        public IAnimalRepository Animal => _animalRepository.Value;

        public IChallengeRepository Challenge => _challengeRepository.Value;

        public ICollectibleRepository Collectible => _collectibleRepository.Value;

        public IFactionRepository Faction => _factionRepository.Value;

        public IFishRepository Fish => _fishRepository.Value;

        public IHorseRepository Horse => _horseRepository.Value;

        public ILocationRepository Location => _locationRepository.Value;

        public IMiscellaneousRepository Miscellaneous => _miscellaneousRepository.Value;

        public IPlantRepository Plant => _plantRepository.Value;

        public IRandomencounterRepository Randomencounter => _randomencounterRepository.Value;

        public ISidequestRepository Sidequest => _sidequestRepository.Value;

        public IStoryquestRepository Storyquest => _storyquestRepository.Value;

        public ITablegameRepository Tablegame => _tablegameRepository.Value;

        public IUserAnimalRepository UserAnimal => _userAnimalRepository.Value;

        public IUserChallengeRepository UserChallenge => _userChallengeRepository.Value;

        public IUserCollectibleRepository UserCollectible => _userCollectibleRepository.Value;

        public IUserFactionRepository UserFaction => _userFactionRepository.Value;

        public IUserFishRepository UserFish => _userFishRepository.Value;

        public IUserHorseRepository UserHorse => _userHorseRepository.Value;

        public IUserMiscellaneousRepository UserMiscellaneous => _userMiscellaneousRepository.Value;

        public IUserPlantRepository UserPlant => _userPlantRepository.Value;

        public IUserRandomencounterRepository UserRandomencounter => _userRandomencounterRepository.Value;

        public IUserRepository User => _userRepository.Value;

        public IUserSidequestRepository UserSidequest => _userSidequestRepository.Value;

        public IUserStoryquestRepository UserStoryquest => _userStoryquestRepository.Value;

        public IUserTablegameRepository UserTablegame => _userTablegameRepository.Value;

        public IUserWeaponRepository UserWeapon => _userWeaponRepository.Value;

        public IWeaponRepository Weapon => _weaponRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
