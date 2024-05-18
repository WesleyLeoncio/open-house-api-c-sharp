using AutoMapper;

using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.models.request;
using open_house_api_c_sharp.modules.filme.models.response;
using open_house_api_c_sharp.modules.filme.repository.interfaces;
using open_house_api_c_sharp.modules.filme.service.interfaces;

namespace open_house_api_c_sharp.modules.filme.service;

public class FilmeService : IFilmeService
{
    private IFilmeRepository _repository;
    
    private IMapper _mapper;

    public FilmeService(IFilmeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public FilmeResponse Create(FilmeRequest request)
    {
        Filme newFilme = _mapper.Map<Filme>(request);
        return _mapper.Map<FilmeResponse>(_repository.Insert(newFilme));
    }

    public IEnumerable<FilmeResponse> GetAll(int skip = 0, int take = 10)
    {
        return _mapper.Map<IEnumerable<FilmeResponse>>(_repository.GetAll(skip, take));
    }
}