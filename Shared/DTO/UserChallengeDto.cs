﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserChallengeDto
    {
        public string UserId { get; init; }
        public int ChallengeId { get; init; }
        public Challenge Challenge { get; init; } = null!;
    }
}
