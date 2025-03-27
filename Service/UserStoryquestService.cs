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
