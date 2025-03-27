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
        BaseDto<UserWeaponDto> GetAll(string userId, bool trackChanges);
        UserWeaponDto GetOne(string userId, int id, bool trackChanges);
    }
}
