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
    public class UserRandomencounterRepository : RepositoryBase<UserRandomencounter>, IUserRandomencounterRepository
    {
        public UserRandomencounterRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectRandomEncounter(UserRandomencounter randomEncounter)
        {
            Create(randomEncounter);
        }

        public void DeleteRandomRandomEncounter(UserRandomencounter randomEncounter)
        {
            Delete(randomEncounter);
        }

        public UserRandomencounter GetFoundRandomEncounter(string userId, int randomEncounterId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.RandomencounterId.Equals(randomEncounterId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Randomencounter)
                .SingleOrDefault();
        }

        public IEnumerable<UserRandomencounter> GetUserFoundRandomEncounter(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Randomencounter)
                .OrderBy(x => x.RandomencounterId)
                .ToList();
        }
    }
}
