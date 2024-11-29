using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ILocationService
    {
        BaseDto<LocationDto> GetAll(bool trackChanges);
        LocationDto GetOne(int id, bool trackChanges);
    }
}
