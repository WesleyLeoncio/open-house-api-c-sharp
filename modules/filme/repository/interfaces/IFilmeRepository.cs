using open_house_api_c_sharp.modules.filme.models.entity;

namespace open_house_api_c_sharp.modules.filme.repository.interfaces;

public interface IFilmeRepository
{
    public IEnumerable<Filme> GetAll(int skip = 0, int take = 10);
    
    public Filme Insert(Filme filme);
}