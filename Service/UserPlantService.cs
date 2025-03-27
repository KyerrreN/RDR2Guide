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
    public class UserPlantService : IUserPlantService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserPlantService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserPlantDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var plants = _repository.UserPlant.GetUserFoundPlants(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserPlantDto>>(plants);
            var final = new BaseDto<UserPlantDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserPlantDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var plant = _repository.UserPlant.GetFoundPlant(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't collected plant with id: {id}");

            return _mapper.Map<UserPlantDto>(plant);
        }
    }
}
