using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserTablegameRepository
    {
        IEnumerable<UserTablegame> GetUserFoundTableGames(string userId, bool trackChanges);
        UserTablegame GetFoundTableGame(string userId, int tableGameId, bool trackChanges);
    }
}
