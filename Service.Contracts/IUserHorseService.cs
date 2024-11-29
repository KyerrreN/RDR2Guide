using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserHorseService
    {
        BaseDto<UserHorseDto> GetAll(int userId, bool trackChanges);
        UserHorseDto GetOne(int userId, int id, bool trackChanges);
    }
}
