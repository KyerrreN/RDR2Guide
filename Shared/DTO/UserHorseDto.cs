using Entities.Models;

namespace Shared.DTO
{
    public record UserHorseDto
    {
        public int UserId { get; init; }
        public int HorseId { get; init; }
        public Horse Horse { get; init; } = null!;
    }
}
