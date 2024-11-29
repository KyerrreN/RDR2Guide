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
        BaseDto<UserPlantDto> GetAll(int userId, bool trackChanges);
        UserPlantDto GetOne(int userId, int id, bool trackChanges);
    }
}
