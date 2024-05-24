using open_house_api_c_sharp.infra.data;
using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.categoria.repository.interfaces;

namespace open_house_api_c_sharp.modules.categoria.repository;

public class CategoriaRepository : ICategoriaRepository
{
    private ConnectionContext _context;

    public CategoriaRepository(ConnectionContext context)
    {
        _context = context;
    }

    public Categoria? GetById(Guid id)
    {
        return _context.CategoriaBd!.FirstOrDefault(categoria => categoria.Id == id);
    }
    
    public Categoria? GetByName(string nome)
    {
        return _context.CategoriaBd!.FirstOrDefault(categoria => categoria.Nome == nome);
    }

    public IEnumerable<Categoria> GetAll(int skip = 0, int take = 10)
    {
        return _context.CategoriaBd!.Skip(skip).Take(take);
    }

    public Categoria Insert(Categoria categoria)
    {
        _context.CategoriaBd!.Add(categoria);
        _context.SaveChanges();
        return categoria;
    }

    public Categoria Update(Categoria categoria)
    {
        _context.SaveChanges();
        return categoria;
    }

    public void Delete(Categoria? categoria)
    {
        _context.CategoriaBd!.Remove(categoria);
        _context.SaveChanges();
    }
    
}