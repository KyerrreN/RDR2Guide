using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserCollectibleService
    {
        BaseDto<UserCollectibleDto> GetAll(int userId, bool trackChanges);
        UserCollectibleDto GetOne(int userId, int id, bool trackChanges);
    }
}
