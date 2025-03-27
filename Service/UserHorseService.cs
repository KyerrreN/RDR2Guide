using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserHorseService : IUserHorseService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserHorseService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Horse.GetHorse(id, false)
                ?? throw new NotFoundException("Horse with specified id does not exist");

            var existing = _repository.UserHorse.GetFoundHorse(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserHorse
            {
                UserId = userId,
                HorseId = id,
            };
            _repository.UserHorse.CollectHorse(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Horse.GetHorse(id, false)
                ?? throw new NotFoundException("Horse with specified id does not exist");

            var existing = _repository.UserHorse.GetFoundHorse(userId, id, false)
                ?? throw new NotFoundException("Horse was not found");

            _repository.UserHorse.DeleteHorse(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserHorseDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var horses = _repository.UserHorse.GetUserFoundHorses(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserHorseDto>>( horses);
            var final = new BaseDto<UserHorseDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserHorseDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesn't exist");

            var horse = _repository.UserHorse.GetFoundHorse(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found horse with id: {id}");

            return _mapper.Map<UserHorseDto>(horse);
        }
    }
}
