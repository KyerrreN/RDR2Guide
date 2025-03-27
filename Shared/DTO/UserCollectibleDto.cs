using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserCollectibleDto
    {
        public string UserId { get; init; }
        public int CollectibleId { get; init; }
        public Collectible Collectible { get; init; } = null!;
    }
}
