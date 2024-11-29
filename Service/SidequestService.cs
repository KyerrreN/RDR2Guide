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
    public class SidequestService : ISidequestService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public SidequestService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<SidequestDto> GetAll(bool trackChanges)
        {
            var sideQuests = _repository.Sidequest.GetAllSidequests(trackChanges);

            var dto = _mapper.Map<IEnumerable<SidequestDto>>(sideQuests);
            var final = new BaseDto<SidequestDto>()
            {
                Data = dto
            };

            return final;
        }

        public SidequestDto GetOne(int id, bool trackChanges)
        {
            var sideQuest = _repository.Sidequest.GetSidequest(id, trackChanges);

            if (sideQuest == null)
                throw new NotFoundException($"Side quest with id: {id} doesnt exist");

            var dto = _mapper.Map<SidequestDto>(sideQuest);

            return dto;
        }
    }
}
