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
