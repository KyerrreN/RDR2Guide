﻿namespace Entities.Models
{
    public class UserWeapon
    {
        public string UserId { get; set; }
        public int WeaponId { get; set; }

        // RELATIONSHIP
        public User User { get; set; } = null!;
        public Weapon Weapon { get; set; } = null!;
    }
}
