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
    public class AnimalRepository : RepositoryBase<Animal>, IAnimalRepository
    {
        public AnimalRepository(RepositoryContext context)
            :base (context)
        {
            
        }
        public IEnumerable<Animal> GetAllAnimals(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Include(x => x.Location)
                .OrderBy(a => a.Id)
                .ToList();
        }

        public Animal GetAnimal(int id, bool trackChanges)
        {
            return FindByCondition(a => a.Id.Equals(id), trackChanges)
                .Include(x => x.Location)
                .SingleOrDefault();
        }
    }
}
