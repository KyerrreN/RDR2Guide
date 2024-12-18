﻿using AutoMapper;
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
    public class UserHorseService : IUserHorseService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserHorseService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserHorseDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var horses = _repository.UserHorse.GetUserFoundHorses(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserHorseDto>>( horses);
            var final = new BaseDto<UserHorseDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserHorseDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesn't exist");

            var horse = _repository.UserHorse.GetFoundHorse(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found horse with id: {id}");

            return _mapper.Map<UserHorseDto>(horse);
        }
    }
}
