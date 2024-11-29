using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserFishService
    {
        BaseDto<UserFishDto> GetAll(int userId, bool trackChanges);
        UserFishDto GetOne(int userId, int id, bool trackChanges);
    }
}
