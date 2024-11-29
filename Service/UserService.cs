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
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BaseDto<UserDto> GetAll(bool trackChanges)
        {
            var users = _repository.User.GetAllUsers(trackChanges);

            var dto = _mapper.Map<IEnumerable<UserDto>>(users);

            var final = new BaseDto<UserDto>()
            {
                Data = dto
            };

            return final;
        }

        public UserDto GetOne(int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(id, trackChanges);

            if (user is null)
                throw new NotFoundException($"User with id: {id} doesnt exist");

            return _mapper.Map<UserDto>(user);
        }
    }
}
