using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

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
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Plant.GetPlant(id, false)
                ?? throw new NotFoundException("Plant with specified id does not exist");

            var existing = _repository.UserPlant.GetFoundPlant(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserPlant
            {
                UserId = userId,
                PlantId = id,
            };
            _repository.UserPlant.CollectPlant(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Plant.GetPlant(id, false)
                ?? throw new NotFoundException("Plant with specified id does not exist");

            var existing = _repository.UserPlant.GetFoundPlant(userId, id, false)
                ?? throw new NotFoundException("Plant was not found");

            _repository.UserPlant.DeletePlant(existing);
            await _repository.SaveAsync();
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
