namespace Exceptions;

public class UsersException : Exception
{
    private readonly string _message;

    private readonly int _statusCode = 400;

    public UsersException(string message, int statusCode)
    {
        _message = message;
        _statusCode = statusCode;
    }
    // create result expection generic
    public IResult ReturnResult => ReturnResultWithMessage();

    private IResult ReturnResultWithMessage()
    {
        switch (_statusCode)
        {
            case 400:
                return Results.BadRequest(_message);
            case 401:
                return Results.Unauthorized();
            case 403:
                return Results.Forbid();
            case 404:
                return Results.NotFound(_message);
            case 500:
                return Results.Problem(_message);
            default:
                return Results.StatusCode(_statusCode);
        }

    }
}