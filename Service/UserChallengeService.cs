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

        public async Task Collect(string userId, int id)
        {
            var found = _repository.Challenge.GetChallenge(id, false)
                ?? throw new NotFoundException("Challenge with specified id does not exist");

            var existing = _repository.UserChallenge.GetFoundChallenge(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var challenge = new UserChallenge
            {
                UserId = userId,
                ChallengeId = id,
            };
            _repository.UserChallenge.CollectChallenge(challenge);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Challenge.GetChallenge(id, false)
                ?? throw new NotFoundException("Challenge with specified id does not exist");

            var existing = _repository.UserChallenge.GetFoundChallenge(userId, id, false)
                ?? throw new NotFoundException("Challenge was not found");

            _repository.UserChallenge.DeleteChallenge(existing);
            await _repository.SaveAsync();
        }

        public BaseDto<UserChallengeDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges);

            //if (user is null)
            //    throw new NotFoundException($"User with id: {userId} doesnt exist");

            var challenges = _repository.UserChallenge.GetUserFoundChallenges(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserChallengeDto>>(challenges);

            var final = new BaseDto<UserChallengeDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserChallengeDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var challenge = _repository.UserChallenge.GetFoundChallenge(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't completed a challenge with id: {id}");

            return _mapper.Map<UserChallengeDto>(challenge);
        }
    }
}
