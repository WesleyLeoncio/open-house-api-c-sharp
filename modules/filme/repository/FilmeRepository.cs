﻿using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.infra.data;
using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.repository.interfaces;

namespace open_house_api_c_sharp.modules.filme.repository;

public class FilmeRepository : IFilmeRepository
{
    private ConectionContext _context;

    public FilmeRepository(ConectionContext context)
    {
        _context = context;
    }

    public IEnumerable<Filme> GetAll(int skip = 0, int take = 10)
    {
        return _context.FilmeBd!
            .Include(filme =>filme.Categorias)
            .Skip(skip).Take(take);
    }

    public Filme Insert(Filme filme)
    {
        _context.FilmeBd!.Add(filme);
        _context.SaveChanges();
        return filme;
    }

}