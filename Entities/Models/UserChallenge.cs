﻿namespace Entities.Models
{
    public class UserChallenge
    {
        public int UserId { get; set; }
        public int ChallengeId { get; set; }

        // RL
        public User User { get; set; } = null!;
        public Challenge Challenge { get; set; } = null!;
    }
}
