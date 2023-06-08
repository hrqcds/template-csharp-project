using Interfaces;
using Services;

namespace Controllers.User;

public class List
{
    public static async Task<IResult> Call(IUserRepository userRepository, int number)
    {
        try
        {
            var userService = new UserService(userRepository);
            var users = await userService.GetUsers();

            return Results.Ok(users);
        }
        catch (Exceptions.UsersException ex)
        {
            return ex.ReturnResult;
        }
    }
}