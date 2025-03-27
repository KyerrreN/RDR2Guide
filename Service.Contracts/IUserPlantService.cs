using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserPlantService
    {
        BaseDto<UserPlantDto> GetAll(string userId, bool trackChanges);
        UserPlantDto GetOne(string userId, int id, bool trackChanges);
    }
}
