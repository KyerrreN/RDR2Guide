using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserStoryquestRepository
    {
        IEnumerable<UserStoryquest> GetUserFoundStoryQuests(string userId, bool trackChanges);
        UserStoryquest GetFoundStoryQuest(string userId, int storyQuestId, bool trackChanges);
    }
}
