using Microsoft.AspNetCore.Mvc;
using open_house_api_c_sharp.modules.filme.models.entity;
using open_house_api_c_sharp.modules.filme.models.request;
using open_house_api_c_sharp.modules.filme.models.response;
using open_house_api_c_sharp.modules.filme.service.interfaces;


namespace open_house_api_c_sharp.modules.filme.controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private IFilmeService _filmeService;

    public FilmeController(IFilmeService filmeService)
    {
        _filmeService = filmeService;
    }
    //TODO REFATORAR PARA PADRAO CREATE 
    [HttpPost]
    public IActionResult CadastroFilme([FromBody] FilmeRequest resquest)
    {
        FilmeResponse response = _filmeService.Create(resquest);
        return Ok(response);
    }
    
    [HttpGet]
    public IActionResult ListarFilmes([FromQuery] int skip = 0,
        [FromQuery] int take = 10)
    {
        return Ok(_filmeService.GetAll(skip, take));
    }
}