using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ISidequestService
    {
        BaseDto<SidequestDto> GetAll(bool trackChanges);
        SidequestDto GetOne(int id, bool trackChanges);
    }
}
