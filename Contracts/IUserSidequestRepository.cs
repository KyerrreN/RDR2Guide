using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserSidequestRepository
    {
        IEnumerable<UserSidequest> GetUserFoundSideQuests(string userId, bool trackChanges);
        UserSidequest GetFoundSideQuest(string userId, int sideQuestId, bool trackChanges);
    }
}
