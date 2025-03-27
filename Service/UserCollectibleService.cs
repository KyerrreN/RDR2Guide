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
    public class UserCollectibleService : IUserCollectibleService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserCollectibleService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserCollectibleDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var collectibles = _repository.UserCollectible.GetUserFoundCollectibles(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserCollectibleDto>>(collectibles);
            var final = new BaseDto<UserCollectibleDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserCollectibleDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var collectible = _repository.UserCollectible.GetFoundCollectible(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found collectible with id: {id}");

            var dto = _mapper.Map<UserCollectibleDto>(collectible);

            return dto;
        }
    }
}
