using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserWeaponService
    {
        BaseDto<UserWeaponDto> GetAll(int userId, bool trackChanges);
        UserWeaponDto GetOne(int userId, int id, bool trackChanges);
    }
}
