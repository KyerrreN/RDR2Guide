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
    public class UserChallengeRepository : RepositoryBase<UserChallenge>, IUserChallengeRepository
    {
        public UserChallengeRepository(RepositoryContext context) : base(context)
        {
        }

        public UserChallenge GetFoundChallenge(int userId, int challengeId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.ChallengeId.Equals(challengeId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Challenge)
                .SingleOrDefault();
        }

        public IEnumerable<UserChallenge> GetUserFoundChallenges(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Challenge)
                .OrderBy(x => x.ChallengeId)
                .ToList();                
        }
    }
}