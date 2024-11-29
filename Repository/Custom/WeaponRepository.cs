using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class WeaponRepository : RepositoryBase<Weapon>, IWeaponRepository
    {
        public WeaponRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Weapon> GetAllWeapons(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Weapon GetWeapon(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                 .SingleOrDefault();
        }
    }
}
