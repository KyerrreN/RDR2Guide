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
        IEnumerable<UserCollectible> GetUserFoundCollectibles(string userId, bool trackChanges);
        UserCollectible GetFoundCollectible(string userId, int animalId, bool trackChanges);
    }
}
