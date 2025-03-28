﻿namespace Entities.Models
{
    public class UserAnimal
    {
        public string UserId { get; set; }
        public int AnimalId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Animal Animal { get; set; } = null!;
    }
}
