using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.infra.data;
using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.repository.interfaces;

namespace open_house_api_c_sharp.modules.filme.repository;

public class FilmeRepository : IFilmeRepository
{
    private readonly ConnectionContext _context;

    public FilmeRepository(ConnectionContext context)
    {
        _context = context;
    }

    public IEnumerable<Filme> GetAll(int skip = 0, int take = 10)
    {
        return _context.FilmeBd!.AsNoTracking()
            .Include(filme =>filme.Categorias)
            .Skip(skip).Take(take);
    }

    public Filme Insert(Filme filme)
    {
        // Adicionando o filme ao contexto
        _context.FilmeBd?.Add(filme);

        // Salvando as alterações
        _context.SaveChanges();
        return filme;
    }

}