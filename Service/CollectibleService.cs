using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DTO;
using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CollectibleService : ICollectibleService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public CollectibleService(IRepositoryManager repository,
                                  IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<CollectibleDto> GetAll(bool trackChanges)
        {
            var collectibles = _repository.Collectible.GetAllCollectibles(trackChanges);

            var collecitblesDto = _mapper.Map<IEnumerable<CollectibleDto>>(collectibles);
            var final = new BaseDto<CollectibleDto>()
            {
                Data = collecitblesDto
            };

            return final;
        }

        public CollectibleDto GetOne(int id, bool trackChanges)
        {
            var collectible = _repository.Collectible.GetCollectible(id, trackChanges);

            if (collectible is null)
                throw new NotFoundException($"Collectible with id: {id} doesnt exist");

            var dto = _mapper.Map<CollectibleDto>(collectible);

            return dto;
        }
    }
}
