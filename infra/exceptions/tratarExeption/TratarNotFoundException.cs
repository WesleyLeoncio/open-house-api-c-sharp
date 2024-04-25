using System.Text.Json;
using open_house_api_c_sharp.infra.exceptions.custom;
using open_house_api_c_sharp.infra.exceptions.interfaces;

namespace open_house_api_c_sharp.infra.exceptions.tratarExeption;

public class TratarNotFoundException : IErrorResultTask
{
    public Task? ValidarException(ErrorExceptionResult error)
    {
        if (error.ExceptionType == typeof(NotFoundException))
        {
            int status = 404;
            string result = JsonSerializer.Serialize(new { status, mensage = error.Msg});
            error.Context.Response.StatusCode = status;
            return error.Context.Response.WriteAsync(result);
        }

        return null;
    }
}