using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using open_house_api_c_sharp.modules.categoria.models.entity;
using open_house_api_c_sharp.modules.filme.models.entity;

namespace open_house_api_c_sharp.infra.data;

public class ConectionContext : DbContext
{
    public ConectionContext(DbContextOptions<ConectionContext> opts) : base(opts){}
    
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

