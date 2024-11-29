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
        IEnumerable<UserAnimal> GetUserFoundAnimals(int userId, bool trackChanges); 
        UserAnimal GetFoundAnimal(int userId, int animalId, bool principalTrackChanges, bool dependentTrackChanges);
    }
}
