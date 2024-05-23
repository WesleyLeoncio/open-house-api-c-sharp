using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.modules.filme.models.entity;

namespace open_house_api_c_sharp.modules.categoria.models.entity;

[Table("categorias")]
[Index(nameof(Nome), IsUnique = true)]
public class Categoria
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name:"id")]
    public Guid Id { get; set; }
    
    [Column(name:"nome", TypeName = "VARCHAR(100)")] 
    public string? Nome { get; set; }
    
    public ICollection<Filme>? Filmes { get; set; }= new List<Filme>();
    
 
}