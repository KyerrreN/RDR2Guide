﻿using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IMiscellaneousService
    {
        BaseDto<MiscellaneousDto> GetAll(bool trackChanges);
        MiscellaneousDto GetOne(int id, bool trackChanges);
    }
}
