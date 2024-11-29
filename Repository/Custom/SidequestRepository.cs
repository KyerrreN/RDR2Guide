using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class SidequestRepository : RepositoryBase<Sidequest>, ISidequestRepository
    {
        public SidequestRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Sidequest> GetAllSidequests(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Sidequest GetSidequest(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
