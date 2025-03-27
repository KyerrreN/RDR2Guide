using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserMiscellaneousRepository
    {
        IEnumerable<UserMiscellaneous> GetUserFoundMiscellaneous(string userId, bool trackChanges);
        UserMiscellaneous GetFoundMiscellaneous(string userId, int miscellaneousId, bool trackChanges);
        void CollectMiscellaneous(UserMiscellaneous userMiscellaneous);
        void DeleteMiscellaneous(UserMiscellaneous userMiscellaneous);
    }
}
