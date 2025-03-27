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
        BaseDto<UserRandomencounterDto> GetAll(string userId, bool trackChanges);
        UserRandomencounterDto GetOne(string userId, int id, bool trackChanges);
        Task Collect(string userId, int id);
        Task Delete(string userId, int id);
    }
}
