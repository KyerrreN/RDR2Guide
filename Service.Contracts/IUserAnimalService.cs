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
        BaseDto<UserAnimalDto> GetAll(int userId, bool trackChanges);
        UserAnimalDto GetOne(int userId, int id, bool trackChanges);
    }
}
