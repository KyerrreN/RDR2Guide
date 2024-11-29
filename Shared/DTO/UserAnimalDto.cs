using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserAnimalDto
    {
        public int UserId { get; init; }
        public int AnimalId { get; init; }
        public Animal Animal { get; init; } = null!;
    }
}
