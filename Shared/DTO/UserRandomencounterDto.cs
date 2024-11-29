using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserRandomencounterDto
    {
        public int UserId { get; init; }
        public int RandomencounterId { get; init; }
        public Randomencounter Randomencounter { get; init; } = null!;
    }
}
