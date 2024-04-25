namespace open_house_api_c_sharp.infra.exceptions.custom
{
    public class NotFoundException : Exception
    {
        public NotFoundException(String msg) : base(msg){}
    }
}