using Microsoft.AspNetCore.Mvc;
using open_house_api_c_sharp.modules.categoria.models.request;
using open_house_api_c_sharp.modules.categoria.models.response;
using open_house_api_c_sharp.modules.categoria.service.interfaces;

namespace open_house_api_c_sharp.modules.categoria.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerBase
{
    private ICategoriaService _service;

    public CategoriaController(ICategoriaService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult CadastroCategoria([FromBody] CategoriaResquest resquest)
    {
        CategoriaResponse response = _service.Create(resquest);
        return CreatedAtAction(nameof(DetalharCategoria),new { id = response.Id }, response);
    }
    
    [HttpGet("{id}")]
    public IActionResult DetalharCategoria(Guid id)
    {
        CategoriaResponse response =  _service.GetId(id);
        return Ok(response);
    }
    
    [HttpGet]
    public IActionResult ListarCategorias([FromQuery] int skip = 0,
        [FromQuery] int take = 10)
    {
        return Ok(_service.GetAll(skip, take));
    }
    
    [HttpPut("{id}")]
    public IActionResult EditarCategoria(Guid id, [FromBody] CategoriaResquest resquest)
    {
        CategoriaResponse response = _service.Update(id, resquest);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public  IActionResult  DeletarCategoria(Guid id)
    { 
        _service.Delete(id);
        return NoContent();
    }
}