using WeightTracker.Application.IServices;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.Services;

public class AdminService : IAdminService
{
    private readonly IUserService _userService;

    public AdminService(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<IEnumerable<Users>> GetAllUsersAsync()
    {
        return await _userService.GetAllUsersIncludingInactiveAsync();
    }

    public async Task<Users?> GetUserByIdAsync(Guid userId)
    {
        return await _userService.GetByIdAsync(userId);
    }

    public async Task<bool> DeactivateUserAsync(Guid userId)
    {
        var allUsers = await _userService.GetAllUsersIncludingInactiveAsync();
        var user = allUsers.FirstOrDefault(u => u.UserId == userId);
        if (user == null) return false;
        
        user.DeletedAt = DateTime.UtcNow;
        await _userService.UpdateAsync(user);
        return true;
    }

    public async Task<bool> ActivateUserAsync(Guid userId)
    {
        var allUsers = await _userService.GetAllUsersIncludingInactiveAsync();
        var user = allUsers.FirstOrDefault(u => u.UserId == userId);
        if (user == null) return false;
        
        user.DeletedAt = null;
        await _userService.UpdateAsync(user);
        return true;
    }
}