using open_house_api_c_sharp.modules.categoria.models.response;

namespace open_house_api_c_sharp.modules.filme.models.response;

public record FilmeResponse(Guid Id, string Nome, string Descricao, DateTime DataLancamento, 
    string Duracao, string Imagem, List<CategoriaResponse> Categorias);