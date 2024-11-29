using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record HorseDto
    {
        public int Id { get; init; }
        public string Breed { get; init; }
        public byte Health { get; init; }
        public byte Stamina { get; init; }

        public byte Speed { get; init; }

        public byte Acceleration { get; init; }

        public string Handling { get; init; }

        public string? Image { get; init; }

        public int LocationId { get; init; }
        public Location Location { get; init; } = null!;
    }
}
