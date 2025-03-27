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

        public async Task Collect(string userId, int id)
        {
            var found = _repository.Collectible.GetCollectible(id, false)
                ?? throw new NotFoundException("Collectible with specified id does not exist");

            var existing = _repository.UserCollectible.GetFoundCollectible(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var userCollectible = new UserCollectible
            {
                UserId = userId,
                CollectibleId = id,
            };
            _repository.UserCollectible.CollectCollectible(userCollectible);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Collectible.GetCollectible(id, false)
                ?? throw new NotFoundException("Collectible with specified id does not exist");

            var existing = _repository.UserCollectible.GetFoundCollectible(userId, id, false)
                ?? throw new NotFoundException("Collectible was not found");

            _repository.UserCollectible.DeleteCollectible(existing);
            await _repository.SaveAsync();
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
