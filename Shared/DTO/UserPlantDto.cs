using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserPlantDto
    {
        public string UserId { get; init; }
        public int PlantId { get; init; }
        public Plant Plant { get; init; } = null!;
    }
}
