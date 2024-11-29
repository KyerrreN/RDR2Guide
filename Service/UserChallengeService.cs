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
    public class UserChallengeService : IUserChallengeService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserChallengeService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserChallengeDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges);

            if (user is null)
                throw new NotFoundException($"User with id: {userId} doesnt exist");

            var challenges = _repository.UserChallenge.GetUserFoundChallenges(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserChallengeDto>>(challenges);

            var final = new BaseDto<UserChallengeDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserChallengeDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var challenge = _repository.UserChallenge.GetFoundChallenge(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't completed a challenge with id: {id}");

            return _mapper.Map<UserChallengeDto>(challenge);
        }
    }
}
