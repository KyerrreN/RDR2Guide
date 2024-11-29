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
    public class UserFishService : IUserFishService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserFishService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserFishDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var fish = _repository.UserFish.GetUserFoundFish(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserFishDto>>(fish);
            var final = new BaseDto<UserFishDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserFishDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var fish = _repository.UserFish.GetFoundFish(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't caught fish with id: {id}");

            return _mapper.Map<UserFishDto>(fish);
        }
    }
}
