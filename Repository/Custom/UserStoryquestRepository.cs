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
    public class UserStoryquestRepository : RepositoryBase<UserStoryquest>, IUserStoryquestRepository
    {
        public UserStoryquestRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectStoryQuest(UserStoryquest storyQuest)
        {
            Create(storyQuest);
        }

        public void DeleteStoryQuest(UserStoryquest storyQuest)
        {
            Delete(storyQuest);
        }

        public UserStoryquest GetFoundStoryQuest(string userId, int storyQuestId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.StoryquestId.Equals(storyQuestId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Storyquest)
                .SingleOrDefault();
        }

        public IEnumerable<UserStoryquest> GetUserFoundStoryQuests(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Storyquest)
                .OrderBy(x => x.StoryquestId)
                .ToList();
        }
    }
}
