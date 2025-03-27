using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

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
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Weapon.GetWeapon(id, false)
                ?? throw new NotFoundException("Weapon with specified id does not exist");

            var existing = _repository.UserWeapon.GetFoundWeapon(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserWeapon
            {
                UserId = userId,
                WeaponId = id,
            };
            _repository.UserWeapon.CollectWeapon(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Weapon.GetWeapon(id, false)
                ?? throw new NotFoundException("Weapon with specified id does not exist");

            var existing = _repository.UserWeapon.GetFoundWeapon(userId, id, false)
                ?? throw new NotFoundException("Weapon was not found");

            _repository.UserWeapon.DeleteWeapon(existing);
            await _repository.SaveAsync();
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
