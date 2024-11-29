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
    public class FactionService : IFactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public FactionService(IRepositoryManager repository,
                              IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BaseDto<FactionDto> GetAll(bool trackChanges)
        {
            var factions = _repository.Faction.GetAllFactions(trackChanges);

            var dto = _mapper.Map<IEnumerable<FactionDto>>(factions);
            var final = new BaseDto<FactionDto>()
            {
                Data = dto
            };

            return final;
        }

        public FactionDto GetOne(int id, bool trackChanges)
        {
            var faction = _repository.Faction.GetFaction(id, trackChanges);

            if (faction is null)
                throw new NotFoundException($"Faction with id: {id} doesnt exist");

            var dto = _mapper.Map<FactionDto>(faction);

            return dto;
        }
    }
}
