using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class FishRepository : RepositoryBase<Fish>, IFishRepository
    {
        public FishRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Fish> GetAllFish(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(f => f.Id)
                .ToList();
        }

        public Fish GetFish(int id, bool trackChanges)
        {
            return FindByCondition(f => f.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
