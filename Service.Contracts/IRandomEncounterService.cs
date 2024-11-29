﻿using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IRandomEncounterService
    {
        BaseDto<RandomencounterDto> GetAll(bool trackChanges);
        RandomencounterDto GetOne(int id, bool trackChanges);
    }
}
