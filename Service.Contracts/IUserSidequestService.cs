using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserSidequestService
    {
        BaseDto<UserSidequestDto> GetAll(string userId, bool trackChanges);
        UserSidequestDto GetOne(string userId, int id, bool trackChanges);
    }
}
