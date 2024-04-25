namespace open_house_api_c_sharp.infra.exceptions.custom;

public class ValidationDuplicateKeyException : Exception
{
    public ValidationDuplicateKeyException(string? message) : base(message)
    {
    }
}