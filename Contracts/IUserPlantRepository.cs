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
        IEnumerable<UserPlant> GetUserFoundPlants(string userId, bool trackChanges);
        UserPlant GetFoundPlant(string userId, int plantId, bool trackChanges);
    }
}
