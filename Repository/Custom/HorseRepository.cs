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
    public class HorseRepository : RepositoryBase<Horse>, IHorseRepository
    {
        public HorseRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Horse> GetAllHorses(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(x => x.Location)
                .OrderBy(x => x.Id)
                .ToList();
        }

        public Horse GetHorse(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .Include(x => x.Location)
                .SingleOrDefault();
        }
    }
}
