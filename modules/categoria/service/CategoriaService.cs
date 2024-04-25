using AutoMapper;
using open_house_api_c_sharp.infra.exceptions.custom;
using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.categoria.models.request;
using open_house_api_c_sharp.modules.categoria.models.response;
using open_house_api_c_sharp.modules.categoria.repository.interfaces;
using open_house_api_c_sharp.modules.categoria.service.interfaces;

namespace open_house_api_c_sharp.modules.categoria.service;

public class CategoriaService : ICategoriaService
{
    private ICategoriaRepository _repository;
    
    private IMapper _mapper;

    public CategoriaService(ICategoriaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public CategoriaResponse Create(CategoriaResquest request)
    {
        Categoria newCategoria = _mapper.Map<Categoria>(request);
        _repository.Insert(newCategoria);
        return _mapper.Map<CategoriaResponse>(newCategoria);
    }

    public CategoriaResponse GetId(Guid id)
    {
        Categoria categoria = VerifyCategory(id);
        return _mapper.Map<CategoriaResponse>(categoria);
    }

    public IEnumerable<CategoriaResponse> GetAll(int skip = 0, int take = 10)
    {
        return _mapper.Map<IEnumerable<CategoriaResponse>>(_repository.GetAll(skip, take));
    }

    public void Delete(Guid id)
    {
        _repository.Delete(VerifyCategory(id));
    }

    public CategoriaResponse Update(Guid id, CategoriaResquest request)
    {
        Categoria categoria = VerifyCategory(id);
        _mapper.Map(request, categoria);
        _repository.Update(categoria);
        return _mapper.Map<CategoriaResponse>(categoria);
    }

    private Categoria VerifyCategory(Guid id)
    {
        return _repository.GetById(id) ??
               throw new NotFoundException("Categoria não encontrada!");
    }

  
}
