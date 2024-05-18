using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.modules.categoria.models.entity;

namespace open_house_api_c_sharp.modules.filme.models.entity;

[Table("filmes")]
[Index(nameof(Nome), IsUnique = true)]
public class Filme
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name:"id")]
    public Guid Id { get; set; }
    
    [Column(name:"nome", TypeName = "VARCHAR(100)")] 
    public string Nome{ get; set; }
    
    [Column(name:"descricao", TypeName = "TEXT")]
    public string Descricao{ get; set; }
    
    [Column(name:"data_lancamento")]
    public DateTime DataLancamento{ get; set; }
    
    [Column(name:"duracao", TypeName = "VARCHAR(30)")] 
    public string Duracao{ get; set; }
    
    [Column(name:"imagem", TypeName = "VARCHAR(100)")] 
    public string Imagem{ get; set; }

    public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
    
    
    public Filme(string nome, string descricao, DateTime dataLancamento, string duracao, string imagem, Guid id)
    {
        Nome = nome;
        Descricao = descricao;
        DataLancamento = dataLancamento;
        Duracao = duracao;
        Imagem = imagem;
        Id = id;
    }

    public Filme()
    {
    }
}