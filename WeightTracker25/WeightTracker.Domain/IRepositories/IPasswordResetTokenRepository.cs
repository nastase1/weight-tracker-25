using System;
using WeightTracker.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTracker.Domain.IRepositories
{
    public interface IPasswordResetTokenRepository
    {
        Task<PasswordResetToken?> GetValidTokenAsync(Guid userId, string resetCode);
        Task AddAsync(PasswordResetToken token);
        Task UpdateAsync(PasswordResetToken token);
        Task DeleteExpiredTokensAsync();
    }
}