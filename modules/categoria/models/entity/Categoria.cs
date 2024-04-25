using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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
    public string Nome { get; set; }

    public Categoria(Guid id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public Categoria(string nome)
    {
        Nome = nome;
    }
}