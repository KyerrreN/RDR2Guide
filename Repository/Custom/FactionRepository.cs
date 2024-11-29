using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class FactionRepository : RepositoryBase<Faction>, IFactionRepository
    {
        public FactionRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Faction> GetAllFactions(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(f => f.Id)
                .ToList();
        }

        public Faction GetFaction(int id, bool trackChanges)
        {
            return FindByCondition(f => f.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
