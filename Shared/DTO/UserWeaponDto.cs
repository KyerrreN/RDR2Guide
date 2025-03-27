using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserWeaponDto
    {
        public string UserId { get; init; }
        public int WeaponId { get; init; }
        public Weapon Weapon { get; init; } = null!;
    }
}
