using open_house_api_c_sharp.modules.categoria.models.entity;

namespace open_house_api_c_sharp.modules.categoria.repository.interfaces;

public interface ICategoriaRepository
{
    public Categoria? GetById(Guid id);

    public Categoria? GetByName(string nome);

    public IEnumerable<Categoria> GetAll(int skip = 0, int take = 10);
    
    public Categoria Insert(Categoria categoria);

    public Categoria Update(Categoria categoria);

    public void Delete(Categoria? categoria);

    
}