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
        IEnumerable<UserFaction> GetUserFoundFactions(int userId, bool trackChanges);
        UserFaction GetFoundFaction(int userId, int factionId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
