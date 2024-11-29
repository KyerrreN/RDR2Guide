using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITablegameRepository
    {
        IEnumerable<Tablegame> GetAllTableGames(int id, bool trackChanges);
        Tablegame GetTableGame(int id, bool trackChanges);
    }   
}
