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
        IEnumerable<UserStoryquest> GetUserFoundStoryQuests(int userId, bool trackChanges);
        UserStoryquest GetFoundStoryQuest(int userId, int storyQuestId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
