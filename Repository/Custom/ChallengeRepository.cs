using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class ChallengeRepository : RepositoryBase<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(RepositoryContext context)
            : base (context)
        {
            
        }

        public IEnumerable<Challenge> GetAllChallenges(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(c => c.Id)
                .ToList();
        }

        public Challenge GetChallenge(int id, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
