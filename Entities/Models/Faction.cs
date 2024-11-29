﻿using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Faction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Leader { get; set; }

        [Required]
        public string Status { get; set; }

        // RL
        public ICollection<User> Users { get; } = [];
        public ICollection<UserFaction> UserFactions { get; } = [];

        public ICollection<Randomencounter> Randomencounters { get; } = [];
    }
}
