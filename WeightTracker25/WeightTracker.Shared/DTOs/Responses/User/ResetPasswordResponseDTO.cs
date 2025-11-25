using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTracker.Shared.DTOs.Responses.User
{
    public class ResetPasswordResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}