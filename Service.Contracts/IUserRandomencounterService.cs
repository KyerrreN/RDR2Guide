using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserRandomencounterService
    {
        BaseDto<UserRandomencounterDto> GetAll(int userId, bool trackChanges);
        UserRandomencounterDto GetOne(int userId, int id, bool trackChanges);
    }
}
