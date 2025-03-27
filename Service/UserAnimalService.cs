using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserAnimalService : IUserAnimalService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserAnimalService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CollectAnimal(string userId, int id)
        {
            var animal = _repository.Animal.GetAnimal(id, false)
                ?? throw new NotFoundException("Couldn't find animal with id " + id);

            var existingAnimal = _repository.UserAnimal.GetFoundAnimal(userId, id, false);
            if (existingAnimal is not null)
                throw new BadRequestException("Duplicate entry");

            var userAnimal = new UserAnimal
            {
                UserId = userId,
                AnimalId = id,
            };

            _repository.UserAnimal.AddFoundAnimal(userAnimal);
            await _repository.SaveAsync();
        }

        public async Task DeleteAnimal(string userId, int id)
        {
            var animal = _repository.Animal.GetAnimal(id, false)
                ?? throw new NotFoundException("Couldn't find animal with id " + id);

            var existingAnimal = _repository.UserAnimal.GetFoundAnimal(userId, id, false) 
                ?? throw new NotFoundException("Animal with id " + id + " is not collected");

            _repository.UserAnimal.DeleteFoundAnimal(existingAnimal);
            await _repository.SaveAsync();
        }

        public BaseDto<UserAnimalDto> GetAll(string userId, bool trackChanges)
        {
            var useranimals = _repository.UserAnimal.GetUserFoundAnimals(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserAnimalDto>>(useranimals);

            var final = new BaseDto<UserAnimalDto>()
            { 
                Data = dto
            };

            return final;
        }

        public UserAnimalDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges);

            //if (user is null)
            //    throw new NotFoundException($"User with id: {userId} doesnt exist in the database");

            var animal = _repository.UserAnimal.GetFoundAnimal(userId, id, trackChanges);

            if (animal is null)
                throw new NotFoundException($"User with id: {userId} hasn't collected animal with id: {id}");

            return _mapper.Map<UserAnimalDto>(animal);
        }
    }
}
