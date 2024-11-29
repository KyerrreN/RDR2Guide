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
    public class FishService : IFishService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public FishService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BaseDto<FishDto> GetAll(bool trackChanges)
        {
            var fish = _repository.Fish.GetAllFish(trackChanges);

            var dto = _mapper.Map<IEnumerable<FishDto>>(fish);
            var final = new BaseDto<FishDto>()
            {
                Data = dto
            };

            return final;
        }

        public FishDto GetOne(int id, bool trackChanges)
        {
            var fish = _repository.Fish.GetFish(id, trackChanges);

            if (fish is null)
                throw new NotFoundException($"Fish with id: {id} doesn't exist");

            return _mapper.Map<FishDto>(fish);
        }
    }
}
