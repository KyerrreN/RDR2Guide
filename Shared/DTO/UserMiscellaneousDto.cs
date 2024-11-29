using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserMiscellaneousDto
    {
        public int UserId { get; init; }
        public int MiscellaneousId { get; init; }
        public Miscellaneous Miscellaneous { get; init; } = null!;
    }
}
