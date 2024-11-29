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

        public UserSidequest GetFoundSideQuest(int userId, int sideQuestId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.SidequestId.Equals(sideQuestId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Sidequest)
                .SingleOrDefault();
        }

        public IEnumerable<UserSidequest> GetUserFoundSideQuests(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Sidequest)
                .OrderBy(x => x.SidequestId)
                .ToList();
        }
    }
}
