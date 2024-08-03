using Microsoft.EntityFrameworkCore;
using ToDo.RestApi.Interfaces;
using ToDo.RestApi.Database;

namespace ToDo.RestApi.Services;

public class UserService : IUserService
{
    private readonly TodoDbContext _context;

    public UserService(TodoDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}