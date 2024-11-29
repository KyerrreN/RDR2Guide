using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IStoryquestService
    {
        BaseDto<StoryquestDto> GetAll(bool trackChanges);
        StoryquestDto GetOne(int id, bool trackChanges);
    }
}
