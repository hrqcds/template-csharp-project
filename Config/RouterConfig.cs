namespace Config;

public class RouterConfig
{
    public static void Run(WebApplication app)
    {
        app.MapGet("/", Controllers.UserController.GetUsers).WithTags("Home");
    }
}