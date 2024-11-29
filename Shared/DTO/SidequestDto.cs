using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record SidequestDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string? Reward { get; init; }

        public string QuestGiver { get; init; }

        public bool IsMissable { get; init; }

        public int? MissableChapter { get; init; }

        public string? Image { get; init; }

        public int LocationId { get; init; }
        public Location Location { get; init; } = null!;
    }
}
