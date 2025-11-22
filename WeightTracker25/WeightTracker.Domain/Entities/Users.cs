using System;
using System.Collections.Generic;

namespace WeightTracker.Domain.Entities
{
    public partial class Users
    {
        public Guid UserId { get; set; }
        public bool IsAdmin { get; set; } = false;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}