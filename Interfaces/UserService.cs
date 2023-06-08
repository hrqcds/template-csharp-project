using Models;

namespace Interfaces;

public interface IUserRepository
{
    User? GetUserById(string id);
    Task<List<User>> GetUsers();
}