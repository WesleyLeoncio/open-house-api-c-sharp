namespace open_house_api_c_sharp.infra.exceptions.interfaces;

public interface IErrorResultTask
{
    public Task? ValidarException(ErrorExceptionResult error);
}