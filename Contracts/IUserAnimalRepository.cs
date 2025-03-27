using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserAnimalRepository
    {
        IEnumerable<UserAnimal> GetUserFoundAnimals(string userId, bool trackChanges); 
        UserAnimal GetFoundAnimal(string userId, int animalId, bool trackChanges);
    }
}
