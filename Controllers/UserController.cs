namespace Controllers;

public class UserController
{
    private readonly WebApplication _app;

    public UserController(WebApplication app)
    {
        _app = app;
    }

    public void Call()
    {

        _app.MapGet("/", Controllers.User.List.Call).WithTags("User");

    }
}