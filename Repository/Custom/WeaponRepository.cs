using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

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
                .Include(x => x.Location)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Weapon GetWeapon(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .Include(x => x.Location)
                 .SingleOrDefault();
        }
    }
}
