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
        BaseDto<UserChallengeDto> GetAll(int userId, bool trackChanges);
        UserChallengeDto GetOne(int userId, int id, bool trackChanges);
    }
}
