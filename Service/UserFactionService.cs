using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserFactionService : IUserFactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserFactionService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Faction.GetFaction(id, false)
                ?? throw new NotFoundException("Faction with specified id does not exist");

            var existing = _repository.UserFaction.GetFoundFaction(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserFaction
            {
                UserId = userId,
                FactionId = id,
            };
            _repository.UserFaction.CollectFaction(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Faction.GetFaction(id, false)
                ?? throw new NotFoundException("Faction with specified id does not exist");

            var existing = _repository.UserFaction.GetFoundFaction(userId, id, false)
                ?? throw new NotFoundException("Faction was not found");

            _repository.UserFaction.DeleteFaction(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserFactionDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var factions = _repository.UserFaction.GetUserFoundFactions(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserFactionDto>>(factions);
            var final = new BaseDto<UserFactionDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserFactionDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var faction = _repository.UserFaction.GetFoundFaction(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found faction with id: {id}");

            return _mapper.Map<UserFactionDto>(faction);
        }
    }
}
