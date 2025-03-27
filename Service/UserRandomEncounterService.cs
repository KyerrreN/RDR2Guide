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
