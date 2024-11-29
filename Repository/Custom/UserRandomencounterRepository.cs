using Contracts;
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

        public UserRandomencounter GetFoundRandomEncounter(int userId, int randomEncounterId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.RandomencounterId.Equals(randomEncounterId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Randomencounter)
                .SingleOrDefault();
        }

        public IEnumerable<UserRandomencounter> GetUserFoundRandomEncounter(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Randomencounter)
                .OrderBy(x => x.RandomencounterId)
                .ToList();
        }
    }
}
