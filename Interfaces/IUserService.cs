namespace ToDo.RestApi.Interfaces;

public interface IUserService
{
    Task<List<User>> GetAllUsersAsync();
}