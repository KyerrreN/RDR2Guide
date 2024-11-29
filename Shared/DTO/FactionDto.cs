using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record FactionDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Leader { get; init; }

        public string Status { get; init; }
    }
}
