using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserFishService : IUserFishService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserFishService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Collect(string userId, int id)
        {
            var found = _repository.Fish.GetFish(id, false)
                ?? throw new NotFoundException("Fish with specified id does not exist");

            var existing = _repository.UserFish.GetFoundFish(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserFish
            {
                UserId = userId,
                FishId = id,
            };
            _repository.UserFish.CollectFish(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Fish.GetFish(id, false)
                ?? throw new NotFoundException("Fish with specified id does not exist");

            var existing = _repository.UserFish.GetFoundFish(userId, id, false)
                ?? throw new NotFoundException("Fish was not found");

            _repository.UserFish.DeleteFish(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserFishDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var fish = _repository.UserFish.GetUserFoundFish(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserFishDto>>(fish);
            var final = new BaseDto<UserFishDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserFishDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var fish = _repository.UserFish.GetFoundFish(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't caught fish with id: {id}");

            return _mapper.Map<UserFishDto>(fish);
        }
    }
}
