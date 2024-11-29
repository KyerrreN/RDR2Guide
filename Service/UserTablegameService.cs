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
        public BaseDto<UserTablegameDto> GetAll(int userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var tablegame = _repository.UserTablegame.GetUserFoundTableGames(userId, trackChanges);

            var dto = _mapper.Map<IEnumerable<UserTablegameDto>>(tablegame);
            var final = new BaseDto<UserTablegameDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserTablegameDto GetOne(int userId, int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} doesnt exist");

            var tablegame = _repository.UserTablegame.GetFoundTableGame(userId, id, trackChanges)
                ?? throw new NotFoundException($"User with id: {userId} hasn't played a table game with id: {id}");

            return _mapper.Map<UserTablegameDto>(tablegame);
        }
    }
}
