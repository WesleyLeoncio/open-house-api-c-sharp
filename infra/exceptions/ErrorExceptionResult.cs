using System.Text.Json;

namespace open_house_api_c_sharp.infra.exceptions;

public class ErrorExceptionResult
{
    public HttpContext Context { get; set; }
    public string Msg { get; set; }
    public Type ExceptionType { get; set; }

    public ErrorExceptionResult(HttpContext context, Exception exception)
    {
        Context = context;
        Msg = exception.Message;
        ExceptionType = exception.GetType();
    }

    public Task GetResultPadrao(Exception exception)
    {
        string msg = exception.Message;
        int status = 500;
        string result = JsonSerializer.Serialize(new { status , mensage = msg});
        Context.Response.StatusCode = status;
        return Context.Response.WriteAsync(result);
    }
}