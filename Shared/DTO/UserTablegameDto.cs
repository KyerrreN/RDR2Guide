using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserTablegameDto
    {
        public string UserId { get; init; }
        public int TablegameId { get; init; }
        public Tablegame Tablegame { get; init; } = null!;
    }
}
