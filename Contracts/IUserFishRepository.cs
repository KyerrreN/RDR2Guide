using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserFishRepository
    {
        IEnumerable<UserFish> GetUserFoundFish(string userId, bool trackChanges);
        UserFish GetFoundFish(string userId, int fishId, bool trackChanges);
    }
}
