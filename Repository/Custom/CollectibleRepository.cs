using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class CollectibleRepository : RepositoryBase<Collectible>, ICollectibleRepository
    {
        public CollectibleRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Collectible> GetAllCollectibles(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(x => x.Sidequest)
                .OrderBy(c => c.Id)
                .ToList();
        }

        public Collectible GetCollectible(int id, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(id), trackChanges)
                .Include(x => x.Sidequest)
                .SingleOrDefault();
        }
    }
}
