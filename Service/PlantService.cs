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
    public class PlantService : IPlantService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public PlantService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<PlantDto> GetAll(bool trackChanges)
        {
            var plants = _repository.Plant.GetAllPlants(trackChanges);

            var dto = _mapper.Map<IEnumerable<PlantDto>>(plants);
            var final = new BaseDto<PlantDto>()
            {
                Data = dto
            };

            return final;
        }

        public PlantDto GetOne(int id, bool trackChanges)
        {
            var plant = _repository.Plant.GetPlant(id, trackChanges);

            if (plant is null)
                throw new NotFoundException($"Plant with id: {id} doesnt exist");

            return _mapper.Map<PlantDto>(plant);
        }
    }
}
