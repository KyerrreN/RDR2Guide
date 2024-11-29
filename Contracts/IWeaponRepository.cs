using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IWeaponRepository
    {
        IEnumerable<Weapon> GetAllWeapons(int id, bool trackChanges);
        Weapon GetWeapon(int id, bool trackChanges);
    }
}
