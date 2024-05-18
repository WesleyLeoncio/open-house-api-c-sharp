using AutoMapper;
using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.categoria.models.request;
using open_house_api_c_sharp.modules.categoria.models.response;

namespace open_house_api_c_sharp.modules.categoria.models.profiles;

public class CategoriaProfile : Profile
{
    public CategoriaProfile()
    {
        CreateMap<Categoria, CategoriaResponse>();
        CreateMap<CategoriaResquest, Categoria>();
        CreateMap<CategoriaFilmeRequest, Categoria>();
    }
}