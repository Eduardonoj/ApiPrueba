using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrueba;

[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    ICategoriaService categoriaService;

    public CategoriaController(ICategoriaService service){
        categoriaService = service;
    }

    [HttpGet]
    public IActionResult Get(){
         return Ok(categoriaService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Categoria categoria){
        categoriaService.Save(categoria);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id,[FromBody] Categoria categoria){
        categoriaService.Update(id,categoria);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id){
        categoriaService.Delete(id);
        return Ok();
    }
       
    
    
}
