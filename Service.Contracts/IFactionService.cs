using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IFactionService
    {
        BaseDto<FactionDto> GetAll(bool trackChanges);
        FactionDto GetOne(int id, bool trackChanges);
    }
}
