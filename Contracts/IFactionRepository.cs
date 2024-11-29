using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFactionRepository
    {
        IEnumerable<Faction> GetAllFactions(int id, bool trackChanges);
        Faction GetFaction(int id, bool trackChanges);
    }
}
