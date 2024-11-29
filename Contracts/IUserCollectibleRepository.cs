using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserCollectibleRepository
    {
        IEnumerable<UserCollectible> GetUserFoundCollectibles(int userId, bool trackChanges);
        UserCollectible GetFoundCollectible(int userId, int animalId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
