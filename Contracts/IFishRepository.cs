using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFishRepository
    {
        IEnumerable<Fish> GetAllFish(bool trackChanges);
        Fish GetFish(int id, bool trackChanges);
    }
}
