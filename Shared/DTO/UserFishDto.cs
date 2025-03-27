using Entities.Models;

namespace Shared.DTO
{
    public record UserFishDto
    {
        public string UserId { get; init; }
        public int FishId { get; init; }
        public Fish Fish { get; init; } = null!;
    }
}
