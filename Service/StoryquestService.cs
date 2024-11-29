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
    public class StoryquestService : IStoryquestService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public StoryquestService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<StoryquestDto> GetAll(bool trackChanges)
        {
            var storyquests = _repository.Storyquest.GetAllStoryQuests(trackChanges);

            var dto = _mapper.Map<IEnumerable<StoryquestDto>>(storyquests);
            var final = new BaseDto<StoryquestDto>()
            {
                Data = dto
            };

            return final;
        }

        public StoryquestDto GetOne(int id, bool trackChanges)
        {
            var storyquest = _repository.Storyquest.GetStoryQuest(id, trackChanges);

            if (storyquest is null)
                throw new NotFoundException($"Story quest with id: {id} doesnt exist in the database");

            return _mapper.Map<StoryquestDto>(storyquest);
        }
    }
}
