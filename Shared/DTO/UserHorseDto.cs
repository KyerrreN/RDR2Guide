using Entities.Models;

namespace Shared.DTO
{
    public record UserHorseDto
    {
        public string UserId { get; init; }
        public int HorseId { get; init; }
        public Horse Horse { get; init; } = null!;
    }
}
