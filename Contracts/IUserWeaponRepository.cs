using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserWeaponRepository
    {
        IEnumerable<UserWeapon> GetUserFoundWeapons(int userId, bool trackChanges);
        UserWeapon GetFoundWeapon(int userId, int weaponId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
