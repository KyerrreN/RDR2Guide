using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserSidequestDto
    {
        public string UserId { get; init; }
        public int SidequestId { get; init; }
        public Sidequest Sidequest { get; init; } = null!;
    }
}
