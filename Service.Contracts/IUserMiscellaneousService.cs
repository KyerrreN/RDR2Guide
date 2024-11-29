using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserMiscellaneousService
    {
        BaseDto<UserMiscellaneousDto> GetAll(int userId, bool trackChanges);
        UserMiscellaneousDto GetOne(int userId, int id, bool trackChanges);
    }
}
