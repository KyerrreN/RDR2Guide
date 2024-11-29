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
    public class ChallengeService : IChallengeService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public ChallengeService(IRepositoryManager repository,
                                IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<ChallengeDto> GetAll(bool trackChanges)
        {
            var challenge = _repository.Challenge.GetAllChallenges(trackChanges);

            var challengeDto = _mapper.Map<IEnumerable<ChallengeDto>>(challenge);
            var final = new BaseDto<ChallengeDto>()
            {
                Data = challengeDto,
            };

            return final;
        }

        public ChallengeDto GetOne(int id, bool trackChanges)
        {
            var challenge = _repository.Challenge.GetChallenge(id, trackChanges);

            if (challenge is null)
                throw new NotFoundException($"Challenge with id: {id} doesnt exist");

            var challengeDto = _mapper.Map<ChallengeDto>(challenge);

            return challengeDto;
        }
    }
}
