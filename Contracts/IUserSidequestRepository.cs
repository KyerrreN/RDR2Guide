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
        IEnumerable<UserSidequest> GetUserFoundSideQuests(int userId, bool trackChanges);
        UserSidequest GetFoundSideQuest(int userId, int sideQuestId, bool trackChanges);
    }
}
