using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserStoryquestDto
    {
        public string UserId { get; init; }
        public int StoryquestId { get; init; }
        public Storyquest Storyquest { get; init; } = null!;
    }
}
