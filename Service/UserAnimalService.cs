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
        public BaseDto<UserAnimalDto> GetAll(int userId, bool trackChanges)
        {
            var useranimals = _repository.UserAnimal.GetUserFoundAnimals(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserAnimalDto>>(useranimals);

            var final = new BaseDto<UserAnimalDto>()
            { 
                Data = dto
            };

            return final;
        }

        public UserAnimalDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges);

            if (user is null)
                throw new NotFoundException($"User with id: {userId} doesnt exist in the database");

            var animal = _repository.UserAnimal.GetFoundAnimal(userId, id, trackChanges);

            if (animal is null)
                throw new NotFoundException($"User with id: {userId} hasn't collected animal with id: {id}");

            return _mapper.Map<UserAnimalDto>(animal);
        }
    }
}
