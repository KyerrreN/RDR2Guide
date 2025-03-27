using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserStoryquestService : IUserStoryquestService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserStoryquestService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Storyquest.GetStoryQuest(id, false)
                ?? throw new NotFoundException("Story quest with specified id does not exist");

            var existing = _repository.UserStoryquest.GetFoundStoryQuest(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserStoryquest
            {
                UserId = userId,
                StoryquestId = id,
            };
            _repository.UserStoryquest.CollectStoryQuest(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Storyquest.GetStoryQuest(id, false)
                ?? throw new NotFoundException("Story quest with specified id does not exist");

            var existing = _repository.UserStoryquest.GetFoundStoryQuest(userId, id, false)
                ?? throw new NotFoundException("Story quest was not found");

            _repository.UserStoryquest.DeleteStoryQuest(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserStoryquestDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserStoryquest.GetUserFoundStoryQuests(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserStoryquestDto>>(sq);
            var final = new BaseDto<UserStoryquestDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserStoryquestDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserStoryquest.GetFoundStoryQuest(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't completed story quest with id: {id}");

            return _mapper.Map<UserStoryquestDto>(sq);
        }
    }
}
