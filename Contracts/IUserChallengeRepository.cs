using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserChallengeRepository
    {
        IEnumerable<UserChallenge> GetUserFoundChallenges(int userId, bool trackChanges);
        UserChallenge GetFoundChallenge(int userId, int challengeId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
