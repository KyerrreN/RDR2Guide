using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

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
                .Include(x => x.Location)
                .OrderBy(p => p.Id)
                .ToList();
        }

        public Plant GetPlant(int id, bool trackChanges)
        {
            return FindByCondition(x => x.Id.Equals(id), trackChanges)
                .Include(x => x.Location)
                .SingleOrDefault();
        }
    }
}
