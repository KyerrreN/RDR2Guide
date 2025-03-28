﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record FishDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string Bait { get; init; }

        public bool IsLegendary { get; init; }
        public int LocationId { get; init; }
        public Location Location { get; init; }
    }
}
