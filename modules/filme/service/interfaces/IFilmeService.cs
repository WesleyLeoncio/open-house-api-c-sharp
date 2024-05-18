using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.models.request;
using open_house_api_c_sharp.modules.filme.models.response;

namespace open_house_api_c_sharp.modules.filme.service.interfaces;

public interface IFilmeService
{
    FilmeResponse Create(FilmeRequest request);

    IEnumerable<FilmeResponse> GetAll(int skip = 0, int take = 10);
}