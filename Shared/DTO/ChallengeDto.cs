using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record ChallengeDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public byte Rank { get; init; }

        public string Reward { get; init; }
    }
}
