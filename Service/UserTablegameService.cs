using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;

namespace Service
{
    public class UserTablegameService : IUserTablegameService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserTablegameService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Collect(string userId, int id)
        {
            var found = _repository.Tablegame.GetTableGame(id, false)
                ?? throw new NotFoundException("Table game with specified id does not exist");

            var existing = _repository.UserTablegame.GetFoundTableGame(userId, id, false);
            if (existing is not null)
                throw new BadRequestException("Duplicate entry");

            var foundItem = new UserTablegame
            {
                UserId = userId,
                TablegameId = id,
            };
            _repository.UserTablegame.CollectTableGame(foundItem);
            await _repository.SaveAsync();
        }

        public async Task Delete(string userId, int id)
        {
            var found = _repository.Tablegame.GetTableGame(id, false)
                ?? throw new NotFoundException("Table game with specified id does not exist");

            var existing = _repository.UserTablegame.GetFoundTableGame(userId, id, false)
                ?? throw new NotFoundException("Table game was not found");

            _repository.UserTablegame.DeleteTableGame(existing);
            await _repository.SaveAsync();
        }
        public BaseDto<UserTablegameDto> GetAll(string userId, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var tablegame = _repository.UserTablegame.GetUserFoundTableGames(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserTablegameDto>>(tablegame);
            var final = new BaseDto<UserTablegameDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserTablegameDto GetOne(string userId, int id, bool trackChanges)
        {
            //var user = _repository.User.GetUser(userId, trackChanges)
            //    ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var tablegame = _repository.UserTablegame.GetFoundTableGame(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't played a table game with id: {id}");

            return _mapper.Map<UserTablegameDto>(tablegame);
        }
    }
}
