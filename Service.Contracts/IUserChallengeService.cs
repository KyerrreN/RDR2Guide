using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserChallengeService
    {
        BaseDto<UserChallengeDto> GetAll(string userId, bool trackChanges);
        UserChallengeDto GetOne(string userId, int id, bool trackChanges);
        Task Collect(string userId, int id);
        Task Delete(string userId, int id);
    }
}
