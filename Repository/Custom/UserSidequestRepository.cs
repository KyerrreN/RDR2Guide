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
    public class UserSidequestRepository : RepositoryBase<UserSidequest>, IUserSidequestRepository
    {
        public UserSidequestRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectSideQuest(UserSidequest userSideQuest)
        {
            Create(userSideQuest);
        }

        public void DeleteSideQuest(UserSidequest userSideQuest)
        {
            Delete(userSideQuest);
        }

        public UserSidequest GetFoundSideQuest(string userId, int sideQuestId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.SidequestId.Equals(sideQuestId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Sidequest)
                .SingleOrDefault();
        }

        public IEnumerable<UserSidequest> GetUserFoundSideQuests(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Sidequest)
                .OrderBy(x => x.SidequestId)
                .ToList();
        }
    }
}
