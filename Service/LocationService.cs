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
    public class LocationService : ILocationService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public LocationService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<LocationDto> GetAll(bool trackChanges)
        {
            var locations = _repository.Location.GetAllLocations(trackChanges);

            var dto = _mapper.Map<IEnumerable<LocationDto>>(locations);

            var final = new BaseDto<LocationDto>()
            {
                Data = dto,
            };

            return final;
        }

        public LocationDto GetOne(int id, bool trackChanges)
        {
            var location = _repository.Location.GetLocation(id, trackChanges);

            if (location is null)
                throw new NotFoundException($"Location with id: {id} doesnt exist");

            return _mapper.Map<LocationDto>(location);
        }
    }
}
