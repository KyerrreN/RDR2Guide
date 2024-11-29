using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IWeaponService
    {
        BaseDto<WeaponDto> GetAll(bool trackChanges);
        WeaponDto GetOne(int id, bool trackChanges);
    }
}
