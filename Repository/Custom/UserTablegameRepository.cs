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
    public class UserTablegameRepository : RepositoryBase<UserTablegame>, IUserTablegameRepository
    {
        public UserTablegameRepository(RepositoryContext context) : base(context)
        {
        }

        public void CollectTableGame(UserTablegame tableGame)
        {
            Create(tableGame);
        }

        public void DeleteTableGame(UserTablegame tableGame)
        {
            Delete(tableGame);
        }

        public UserTablegame GetFoundTableGame(string userId, int tableGameId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId) && x.TablegameId.Equals(tableGameId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Tablegame)
                .SingleOrDefault();
        }

        public IEnumerable<UserTablegame> GetUserFoundTableGames(string userId, bool trackChanges)
        {
            return FindByCondition(x => x.UserId.Equals(userId), trackChanges)
                .Include(x => x.User)
                .Include(x => x.Tablegame)
                .OrderBy(x => x.TablegameId)
                .ToList();
        }
    }
}
