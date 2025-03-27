using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserMiscellaneousService : IUserMiscellaneousService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserMiscellaneousService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Miscellaneous.GetMiscellaneous(id, false)
                ?? throw new NotFoundException("Miscellaneous with specified id does not exist");

            var existing = _repository.UserMiscellaneous.GetFoundMiscellaneous(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserMiscellaneous
            {
                UserId = userId,
                MiscellaneousId = id,
            };
            _repository.UserMiscellaneous.CollectMiscellaneous(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Miscellaneous.GetMiscellaneous(id, false)
                ?? throw new NotFoundException("Miscellaneous with specified id does not exist");

            var existing = _repository.UserMiscellaneous.GetFoundMiscellaneous(userId, id, false)
                ?? throw new NotFoundException("Miscellaneous was not found");

            _repository.UserMiscellaneous.DeleteMiscellaneous(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserMiscellaneousDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var miscellaneous = _repository.UserMiscellaneous.GetUserFoundMiscellaneous(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserMiscellaneousDto>>(miscellaneous);

            var final = new BaseDto<UserMiscellaneousDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserMiscellaneousDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var miscellaneous = _repository.UserMiscellaneous.GetFoundMiscellaneous(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't found miscellaneous with id: {id}");

            return _mapper.Map<UserMiscellaneousDto>(miscellaneous);
        }
    }
}
