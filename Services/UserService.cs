using Microsoft.EntityFrameworkCore;
using ToDo.RestApi.Interfaces;
using ToDo.RestApi.Database;

namespace ToDo.RestApi.Services;

public class UserService : IUserService
{
    private readonly ApiDbContext _context;

    public UserService(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}