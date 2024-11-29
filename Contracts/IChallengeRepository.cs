using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IChallengeRepository
    {
        IEnumerable<Challenge> GetAllChallenges(int id, bool trackChanges);
        Challenge GetChallenge(int id, bool trackChanges);
    }
}
