using AutoMapper;
using Contracts;
using Entities.Exceptions;
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
        public BaseDto<UserFactionDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var factions = _repository.UserFaction.GetUserFoundFactions(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserFactionDto>>(factions);
            var final = new BaseDto<UserFactionDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserFactionDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var faction = _repository.UserFaction.GetFoundFaction(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found faction with id: {id}");

            return _mapper.Map<UserFactionDto>(faction);
        }
    }
}
