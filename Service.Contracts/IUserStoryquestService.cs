using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserStoryquestService
    {
        BaseDto<UserStoryquestDto> GetAll(string userId, bool trackChanges);
        UserStoryquestDto GetOne(string userId, int id, bool trackChanges);
    }
}
