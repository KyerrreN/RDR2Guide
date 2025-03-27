using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserAnimalService
    {
        BaseDto<UserAnimalDto> GetAll(string userId, bool trackChanges);
        UserAnimalDto GetOne(string userId, int id, bool trackChanges);
        Task CollectAnimal(string userId, int id);
        Task DeleteAnimal(string userId, int id);
    }
}
