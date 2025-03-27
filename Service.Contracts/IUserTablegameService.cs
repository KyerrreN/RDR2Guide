using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserTablegameService
    {
        BaseDto<UserTablegameDto> GetAll(string userId, bool trackChanges);
        UserTablegameDto GetOne(string userId, int id, bool trackChanges);
    }
}
