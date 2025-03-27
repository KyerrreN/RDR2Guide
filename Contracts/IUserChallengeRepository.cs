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
        IEnumerable<UserChallenge> GetUserFoundChallenges(string userId, bool trackChanges);
        UserChallenge GetFoundChallenge(string userId, int challengeId, bool trackChanges);
    }
}
