using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace RDR2Guide.Mapping_Profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Animal, AnimalDto>();
            CreateMap<Challenge, ChallengeDto>();
            CreateMap<Collectible, CollectibleDto>();
            CreateMap<Faction, FactionDto>();
            CreateMap<Fish, FishDto>();
            CreateMap<Horse,  HorseDto>();
            CreateMap<Location, LocationDto>();
            CreateMap<Miscellaneous, MiscellaneousDto>();
            CreateMap<Plant, PlantDto>();
            CreateMap<Randomencounter, RandomencounterDto>();
            CreateMap<Sidequest, SidequestDto>();
            CreateMap<Storyquest, StoryquestDto>();
            CreateMap<Tablegame, TablegameDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserAnimal, UserAnimalDto>();
            CreateMap<UserChallenge,  UserChallengeDto>();
            CreateMap<UserCollectible, UserCollectibleDto>();
            CreateMap<UserFaction, UserFactionDto>();   
            CreateMap<UserFish,  UserFishDto>();
            CreateMap<UserHorse, UserHorseDto>();
            CreateMap<UserMiscellaneous, UserMiscellaneousDto>();
            CreateMap<UserPlant, UserPlantDto>();
            CreateMap<UserRandomencounter, UserRandomencounterDto>();
            CreateMap<UserSidequest, UserSidequestDto>();
            CreateMap<UserStoryquest, UserStoryquestDto>();
            CreateMap<UserTablegame, UserTablegameDto>();
            CreateMap<UserWeapon, UserWeaponDto>();
            CreateMap<Weapon,  WeaponDto>();
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
