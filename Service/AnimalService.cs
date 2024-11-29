using AutoMapper;
using Contracts;
using Entities.Models;
using RDR2Guide.Extensions;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public AnimalService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BaseDto<AnimalDto> GetAll(bool trackChanges)
        {
            var animal = _repository.Animal.GetAllAnimals(trackChanges);

            var animalDto = _mapper.Map<IEnumerable<AnimalDto>>(animal);
            var finalDto = new BaseDto<AnimalDto>()
            {
                Data = animalDto
            };

            return finalDto;
        }

        public AnimalDto GetOne(int id, bool trackChanges)
        {
            var animal = _repository.Animal.GetAnimal(id, trackChanges);

            if (animal is null)
                throw new NotFoundException($"Animal with id: {id} doesn't exist");

            var animalDto = _mapper.Map<AnimalDto>(animal);

            return animalDto;
        }
    }
}
