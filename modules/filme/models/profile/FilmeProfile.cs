using AutoMapper;
using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.models.request;
using open_house_api_c_sharp.modules.filme.models.response;

namespace open_house_api_c_sharp.modules.filme.models.profile;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<Filme, FilmeResponse>();
        CreateMap<FilmeRequest, Filme>();
    }
}