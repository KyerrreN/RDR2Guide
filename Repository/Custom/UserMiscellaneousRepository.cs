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
    public class UserMiscellaneousRepository : RepositoryBase<UserMiscellaneous>, IUserMiscellaneousRepository
    {
        public UserMiscellaneousRepository(RepositoryContext context) : base(context)
        {
        }

        public UserMiscellaneous GetFoundMiscellaneous(int userId, int miscellaneousId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.MiscellaneousId.Equals(miscellaneousId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Miscellaneous)
                .SingleOrDefault();
        }

        public IEnumerable<UserMiscellaneous> GetUserFoundMiscellaneous(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Miscellaneous)
                .OrderBy(x => x.MiscellaneousId)
                .ToList();
        }
    }
}
