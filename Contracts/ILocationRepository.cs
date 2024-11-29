using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAllLocations(int id, bool trackChanges);
        Location GetLocation(int id, bool trackChanges);
    }
}
