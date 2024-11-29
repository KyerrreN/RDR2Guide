using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPlantRepository
    {
        IEnumerable<Plant> GetAllPlants(bool trackChanges);
        Plant GetPlant(int id, bool trackChanges);  
    }
}
