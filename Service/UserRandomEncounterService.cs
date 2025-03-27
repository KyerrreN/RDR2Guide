using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserRandomEncounterService : IUserRandomencounterService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserRandomEncounterService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Randomencounter.GetRandomEncounter(id, false)
                ?? throw new NotFoundException("Random encounter with specified id does not exist");

            var existing = _repository.UserRandomencounter.GetFoundRandomEncounter(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserRandomencounter
            {
                UserId = userId,
                RandomencounterId = id,
            };
            _repository.UserRandomencounter.CollectRandomEncounter(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Randomencounter.GetRandomEncounter(id, false)
                ?? throw new NotFoundException("Random encounter with specified id does not exist");

            var existing = _repository.UserRandomencounter.GetFoundRandomEncounter(userId, id, false)
                ?? throw new NotFoundException("RandomEncounter was not found");

            _repository.UserRandomencounter.DeleteRandomRandomEncounter(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserRandomencounterDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var re = _repository.UserRandomencounter.GetUserFoundRandomEncounter(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserRandomencounterDto>>(re);
            var final = new BaseDto<UserRandomencounterDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserRandomencounterDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var re = _repository.UserRandomencounter.GetFoundRandomEncounter(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found random encounter with id: {id}");

            return _mapper.Map<UserRandomencounterDto>(re);
        }
    }
}
