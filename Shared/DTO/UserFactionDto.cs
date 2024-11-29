using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserFactionDto
    {
        public int UserId { get; init; }
        public int FactionId { get; init; }
        public Faction Faction { get; init; } = null!;
    }
}
