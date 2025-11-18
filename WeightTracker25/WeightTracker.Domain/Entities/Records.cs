using System;
using System.Collections.Generic;

namespace WeigtTracker.Domain.Entities
{
    public partial class Records
    {
        public Guid RecordId { get; set; }
        public Guid UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Users User { get; set; } = null!;
    }
}