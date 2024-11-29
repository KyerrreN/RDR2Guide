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
    public class UserFishRepository : RepositoryBase<UserFish>, IUserFishRepository
    {
        public UserFishRepository(RepositoryContext context) : base(context)
        {
        }

        public UserFish GetFoundFish(int userId, int fishId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.FishId.Equals(fishId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Fish)
                .SingleOrDefault();
        }

        public IEnumerable<UserFish> GetUserFoundFish(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Fish)
                .OrderBy(x => x.FishId)
                .ToList();
        }
    }
}