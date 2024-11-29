using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record MiscellaneousDto
    {
        public int Id { get; init; }

        public string Name { get; init; }
    }
}
