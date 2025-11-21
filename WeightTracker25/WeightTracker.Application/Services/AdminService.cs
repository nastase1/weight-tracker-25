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
        return await _userService.GetAllAsync();
    }

    public async Task<Users?> GetUserByIdAsync(Guid userId)
    {
        return await _userService.GetByIdAsync(userId);
    }
}