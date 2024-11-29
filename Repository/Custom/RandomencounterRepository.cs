using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class RandomencounterRepository : RepositoryBase<Randomencounter>, IRandomencounterRepository
    {
        public RandomencounterRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Randomencounter> GetAllRandomEncounters(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(r => r.Id)
                .ToList();
        }

        public Randomencounter GetRandomEncounter(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
