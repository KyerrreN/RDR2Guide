using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record AnimalDto
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public string Hostility { get; init; }

        public string? Image { get; init; }

        public bool IsLegendary { get; init; }

        public Location? Location { get; init; }
        public int? LocationId { get; init; }
    }
}
