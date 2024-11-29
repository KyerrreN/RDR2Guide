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
    public class RandomEncounterService : IRandomEncounterService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public RandomEncounterService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<RandomencounterDto> GetAll(bool trackChanges)
        {
            var re = _repository.Randomencounter.GetAllRandomEncounters(trackChanges);
            
            var dto = _mapper.Map<IEnumerable<RandomencounterDto>>(re);
            var final = new BaseDto<RandomencounterDto>()
            {
                Data = dto
            };

            return final;
        }

        public RandomencounterDto GetOne(int id, bool trackChanges)
        {
            var re = _repository.Randomencounter.GetRandomEncounter(id, trackChanges);

            if (re is null)
                throw new NotFoundException($"Random encounter with id: {id} doesnt exist");

            return _mapper.Map<RandomencounterDto>(re);
        }
    }
}
