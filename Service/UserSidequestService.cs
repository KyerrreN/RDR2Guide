using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserSidequestService : IUserSidequestService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserSidequestService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Sidequest.GetSidequest(id, false)
                ?? throw new NotFoundException("Side quest with specified id does not exist");

            var existing = _repository.UserSidequest.GetFoundSideQuest(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserSidequest
            {
                UserId = userId,
                SidequestId = id,
            };
            _repository.UserSidequest.CollectSideQuest(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Sidequest.GetSidequest(id, false)
                ?? throw new NotFoundException("Side quest with specified id does not exist");

            var existing = _repository.UserSidequest.GetFoundSideQuest(userId, id, false)
                ?? throw new NotFoundException("Side quest was not found");

            _repository.UserSidequest.DeleteSideQuest(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserSidequestDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserSidequest.GetUserFoundSideQuests(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserSidequestDto>>(sq);
            var final = new BaseDto<UserSidequestDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserSidequestDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserSidequest.GetFoundSideQuest(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't completed side quest with id: {id}");

            return _mapper.Map<UserSidequestDto>(sq);
        }
    }
}
