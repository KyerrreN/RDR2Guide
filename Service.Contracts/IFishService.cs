﻿using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IFishService
    {
        BaseDto<FishDto> GetAll(bool trackChanges);
        FishDto GetOne(int id, bool trackChanges);
    }
}
