using Interfaces;
using Models.Dtos;

namespace Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<ListUserDto>> GetUsers()
    {
        var users = await _userRepository.GetUsers();

        return ListUserDto.ListUserResponse(users).ToList();
    }
}