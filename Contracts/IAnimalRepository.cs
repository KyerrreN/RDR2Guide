using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAllAnimals(int id, bool trackChanges);
        Animal GetAnimal(int id, bool trackChanges);    
    }
}
