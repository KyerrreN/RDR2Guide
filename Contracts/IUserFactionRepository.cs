using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserFactionRepository
    {
        IEnumerable<UserFaction> GetUserFoundFactions(string userId, bool trackChanges);
        UserFaction GetFoundFaction(string userId, int factionId, bool trackChanges);
        void CollectFaction(UserFaction userFaction);
        void DeleteFaction(UserFaction userFaction);
    }
}
