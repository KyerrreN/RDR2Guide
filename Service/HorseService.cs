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
    public class HorseService : IHorseService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public HorseService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BaseDto<HorseDto> GetAll(bool trackChanges)
        {
            var horses = _repository.Horse.GetAllHorses(trackChanges);

            var dto = _mapper.Map<IEnumerable<HorseDto>>(horses);
            var final = new BaseDto<HorseDto>()
            {
                Data = dto
            };

            return final;
        }

        public HorseDto GetOne(int id, bool trackChanges)
        {
            var horse = _repository.Horse.GetHorse(id, trackChanges);

            if (horse is null)
                throw new NotFoundException($"Horse with id: {id} doesnt exist");

            return _mapper.Map<HorseDto>(horse);
        }
    }
}
