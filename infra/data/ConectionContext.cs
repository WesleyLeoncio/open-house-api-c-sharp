using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.modules.categoria.models.entity;

namespace open_house_api_c_sharp.infra.data;

public class ConectionContext : DbContext
{
    public ConectionContext(DbContextOptions<ConectionContext> opts) : base(opts){}
    
    public DbSet<Categoria>? CategoriaBd { get; set; }
}