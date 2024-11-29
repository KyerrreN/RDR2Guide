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
    public class MiscellaneousService : IMiscellaneousService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public MiscellaneousService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<MiscellaneousDto> GetAll(bool trackChanges)
        {
            var miscellaneous = _repository.Miscellaneous.GetAllMiscellaneous(trackChanges);

            var dto = _mapper.Map<IEnumerable<MiscellaneousDto>>(miscellaneous);

            var final = new BaseDto<MiscellaneousDto>()
            {
                Data = dto
            };

            return final;
        }

        public MiscellaneousDto GetOne(int id, bool trackChanges)
        {
            var miscellaneous = _repository.Miscellaneous.GetMiscellaneous(id, trackChanges);

            if (miscellaneous is null)
                throw new NotFoundException($"Miscellaneous with id: {id} doesnt exist");

            return _mapper.Map<MiscellaneousDto>(miscellaneous);
        }
    }
}
