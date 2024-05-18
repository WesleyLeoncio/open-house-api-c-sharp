using open_house_api_c_sharp.modules.categoria.models.request;

namespace open_house_api_c_sharp.modules.filme.models.request;
//TODO TROCAR CATEGORIA POR CATEGORIAREQUEST
public record FilmeRequest(string Nome, string Descricao, DateTime DataLancamento, 
    string Duracao, string Imagem, List<CategoriaFilmeRequest> Categorias
);