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
    public class TablegameService : ITablegameService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public TablegameService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<TablegameDto> GetAll(bool trackChanges)
        {
            var tablegames = _repository.Tablegame.GetAllTableGames(trackChanges);

            var dto = _mapper.Map<IEnumerable<TablegameDto>>(tablegames);

            var final = new BaseDto<TablegameDto>()
            {
                Data = dto
            };

            return final;
        }

        public TablegameDto GetOne(int id, bool trackChanges)
        {
            var tablegame = _repository.Tablegame.GetTableGame(id, trackChanges);

            if (tablegame is null)
                throw new NotFoundException($"Table game with id: {id} doesnt exist in the database");

            return _mapper.Map<TablegameDto>(tablegame);
        }
    }
}
