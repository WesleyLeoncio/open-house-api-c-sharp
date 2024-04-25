using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.categoria.models.request;
using open_house_api_c_sharp.modules.categoria.models.response;

namespace open_house_api_c_sharp.modules.categoria.service.interfaces;

public interface ICategoriaService
{
    CategoriaResponse Create(CategoriaResquest request);

    CategoriaResponse GetId(Guid id);

    IEnumerable<CategoriaResponse> GetAll(int skip = 0, int take = 10);
    
    void Delete(Guid id);

    CategoriaResponse Update(Guid id, CategoriaResquest request);

    
}