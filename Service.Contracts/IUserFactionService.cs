﻿using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IUserFactionService
    {
        BaseDto<UserFactionDto> GetAll(string userId, bool trackChanges);
        UserFactionDto GetOne(string userId, int id, bool trackChanges);
    }
}
