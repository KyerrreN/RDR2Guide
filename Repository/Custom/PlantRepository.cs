using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Custom
{
    public class PlantRepository : RepositoryBase<Plant>, IPlantRepository
    {
        public PlantRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Plant> GetAllPlants(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(p => p.Id)
                .ToList();
        }

        public Plant GetPlant(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
