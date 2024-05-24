using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.filme.models.entity;

namespace open_house_api_c_sharp.infra.data;

public class ConnectionContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Categoria>? CategoriaBd { get; set; }
    
    public DbSet<Filme>? FilmeBd { get; set; }
    
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Filme>()
    //         .HasMany(e => e.Categorias)
    //         .WithMany()
    //         .UsingEntity("categoria_filme");
    // }
  
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Filme>()
    //         .HasMany(p => p.Categorias)
    //         .WithMany(t => t.Filmes)
    //         .UsingEntity(j => j.ToTable("categoria_filmes"));
    // }
  
}

