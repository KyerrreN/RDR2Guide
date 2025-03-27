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
    public class UserFactionRepository : RepositoryBase<UserFaction>, IUserFactionRepository
    {
        public UserFactionRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectFaction(UserFaction userFaction)
        {
            Create(userFaction);
        }

        public void DeleteFaction(UserFaction userFaction)
        {
            Delete(userFaction);
        }

        public UserFaction GetFoundFaction(string userId, int factionId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.FactionId.Equals(factionId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Faction)
                .SingleOrDefault();
        }

        public IEnumerable<UserFaction> GetUserFoundFactions(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Faction)
                .OrderBy(x => x.FactionId)
                .ToList();
        }
    }
}
