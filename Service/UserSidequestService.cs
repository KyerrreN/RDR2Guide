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
        public BaseDto<UserSidequestDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserSidequest.GetUserFoundSideQuests(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserSidequestDto>>(sq);
            var final = new BaseDto<UserSidequestDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserSidequestDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var sq = _repository.UserSidequest.GetFoundSideQuest(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't completed side quest with id: {id}");

            return _mapper.Map<UserSidequestDto>(sq);
        }
    }
}
