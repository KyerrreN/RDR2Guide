using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRandomencounterRepository
    {
        IEnumerable<Randomencounter> GetAllRandomEncounters(int id, bool trackChanges);
        Randomencounter GetRandomEncounter(int id, bool trackChanges);
    }
}
