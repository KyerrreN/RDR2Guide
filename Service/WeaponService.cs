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
    public class WeaponService : IWeaponService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public WeaponService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BaseDto<WeaponDto> GetAll(bool trackChanges)
        {
            var weapons = _repository.Weapon.GetAllWeapons(trackChanges);

            var dto = _mapper.Map<IEnumerable<WeaponDto>>(weapons);
            var final = new BaseDto<WeaponDto>()
            {
                Data = dto
            };

            return final;
        }

        public WeaponDto GetOne(int id, bool trackChanges)
        {
            var weapon = _repository.Weapon.GetWeapon(id, trackChanges);

            if (weapon is null)
            {
                throw new NotFoundException($"Weapon with id: {id} doesnt exist");
            }

            return _mapper.Map<WeaponDto>(weapon);
        }
    }
}
