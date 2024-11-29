using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class TablegameRepository : RepositoryBase<Tablegame>, ITablegameRepository
    {
        public TablegameRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Tablegame> GetAllTableGames(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Tablegame GetTableGame(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
