using Interfaces;
using Models;

namespace Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User? GetUserById(string id)
    {
        return _userRepository.GetUserById(id);
    }

    public async Task<List<User>> GetUsers()
    {
        return await _userRepository.GetUsers();
    }
}