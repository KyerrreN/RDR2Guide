using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserPlantRepository
    {
        IEnumerable<UserPlant> GetUserFoundPlants(int userId, bool trackChanges);
        UserPlant GetFoundPlant(int userId, int plantId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
