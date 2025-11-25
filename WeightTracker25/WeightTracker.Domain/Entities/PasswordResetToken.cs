using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTracker.Domain.Entities
{
    public class PasswordResetToken
    {
        public Guid TokenId { get; set; }
        public Guid UserId { get; set; }
        public string ResetCode { get; set; } = null!;
        public DateTime ExpiryDate { get; set; }
        public bool IsUsed { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Users User { get; set; } = null!;
    }
}