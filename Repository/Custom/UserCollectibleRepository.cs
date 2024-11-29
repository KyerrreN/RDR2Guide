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
    public class UserCollectibleRepository : RepositoryBase<UserCollectible>, IUserCollectibleRepository
    {
        public UserCollectibleRepository(RepositoryContext context) : base(context)
        {
        }

        public UserCollectible GetFoundCollectible(int userId, int collectibleId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.CollectibleId.Equals(collectibleId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Collectible)
                .SingleOrDefault();
        }

        public IEnumerable<UserCollectible> GetUserFoundCollectibles(int userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Collectible)
                .OrderBy(x => x.CollectibleId)
                .ToList();
        }
    }
}
