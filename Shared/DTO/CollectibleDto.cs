using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record CollectibleDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public byte Amount { get; init; }

        public string? Image { get; init; }

        public int? SidequestId { get; init; }
        public Sidequest? Sidequest { get; init; } = null!;
    }
}
