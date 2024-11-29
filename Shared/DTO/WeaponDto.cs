using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record WeaponDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Damage { get; set; }
        public float Range { get; set; }
        public float FiringRate { get; set; }
        public float Accuracy { get; set; }
        public int? Cost { get; set; }
        public bool IsUnique { get; set; }
        public string? Image { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;
    }
}
