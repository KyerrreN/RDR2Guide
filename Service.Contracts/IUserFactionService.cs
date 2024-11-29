using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserFactionService
    {
        BaseDto<UserFactionDto> GetAll(int userId, bool trackChanges);
        UserFactionDto GetOne(int userId, int id, bool trackChanges);
    }
}
