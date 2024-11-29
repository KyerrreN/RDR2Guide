using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record PlantDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public bool IsEdible { get; init; }
        public string? Image { get; init; }
        public Location Location { get; init; } = null!;
        public int LocationId { get; init; }
    }
}
