﻿using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class UserWeaponRepository : RepositoryBase<UserWeapon>, IUserWeaponRepository
    {
        public UserWeaponRepository(RepositoryContext context) : base(context)
        {
        }

        public UserWeapon GetFoundWeapon(int userId, int weaponId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.WeaponId.Equals(weaponId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Weapon)
                .SingleOrDefault();
        }

        public IEnumerable<UserWeapon> GetUserFoundWeapons(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Weapon)
                .OrderBy(x => x.WeaponId)
                .ToList();
        }
    }
}