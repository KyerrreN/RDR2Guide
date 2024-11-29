using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class MiscellaneousRepository : RepositoryBase<Miscellaneous>, IMiscellaneousRepository
    {
        public MiscellaneousRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Miscellaneous> GetAllMiscellaneous(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Miscellaneous GetMiscellaneous(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                 .SingleOrDefault();
        }
    }
}
