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
        IEnumerable<UserWeapon> GetUserFoundWeapons(string userId, bool trackChanges);
        UserWeapon GetFoundWeapon(string userId, int weaponId, bool trackChanges);
        void CollectWeapon(UserWeapon weapon);
        void DeleteWeapon(UserWeapon weapon);
    }
}
