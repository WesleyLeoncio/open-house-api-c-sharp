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
            string msg = "Registo já existe na base de dados!";
            int status = 409;
            string result = JsonSerializer.Serialize(new { status, mensage = msg});
            error.Context.Response.StatusCode = status;
            return error.Context.Response.WriteAsync(result);
        }

        return null;
    }
}
