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
        IEnumerable<UserMiscellaneous> GetUserFoundMiscellaneous(int userId, bool trackChanges);
        UserMiscellaneous GetFoundMiscellaneous(int userId, int miscellaneousId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
