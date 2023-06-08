using Controllers;

namespace Config;

public class RouterConfig
{
    public static void Run(WebApplication app)
    {
        new UserController(app).Call();
    }
}