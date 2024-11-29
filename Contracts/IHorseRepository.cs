using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHorseRepository
    {
        IEnumerable<Horse> GetAllHorses(int id, bool trackChanges);
        Horse GetHorse(int id, bool trackChanges);
    }
}
