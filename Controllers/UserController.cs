using Database;
using Interfaces;
using Models;
using Repositories;
using Services;

namespace Controllers;

public class UserController
{
    
    public static async Task<IResult> GetUsers(IUserRepository userRepository)
    {
        var users = await userRepository.GetUsers();

        return Results.Ok(users);
    }
}