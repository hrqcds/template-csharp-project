using Models;

namespace Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}