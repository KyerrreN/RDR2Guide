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
    public class UserWeaponService : IUserWeaponService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserWeaponService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserWeaponDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var weapon = _repository.UserWeapon.GetUserFoundWeapons(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserWeaponDto>>(weapon);
            var final = new BaseDto<UserWeaponDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserWeaponDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var weapon = _repository.UserWeapon.GetFoundWeapon(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found weapon with id: {id}");

            return _mapper.Map<UserWeaponDto>(weapon);
        }
    }
}
