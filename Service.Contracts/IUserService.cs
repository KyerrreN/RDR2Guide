using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserService
    {
        BaseDto<UserDto> GetAll(bool trackChanges);
        UserDto GetOne(int id, bool trackChanges);
    }
}
