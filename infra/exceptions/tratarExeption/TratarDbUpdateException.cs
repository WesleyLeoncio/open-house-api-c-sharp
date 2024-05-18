using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.infra.exceptions.interfaces;

namespace open_house_api_c_sharp.infra.exceptions.tratarExeption;

public class TratarDbUpdateException : IErrorResultTask
{
    public Task? ValidarException(ErrorExceptionResult error)
    {
        if (error.ExceptionType == typeof(DbUpdateException))
        {
            int status = 409;
            string result = JsonSerializer.Serialize(new { status, mensage = error.Msg});
            error.Context.Response.StatusCode = status;
            Console.WriteLine(error);
            return error.Context.Response.WriteAsync(result);
        }
        
        return null;
    }
}
