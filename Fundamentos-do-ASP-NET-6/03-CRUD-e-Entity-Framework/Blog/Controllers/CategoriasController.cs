using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
public class CategoriasController : ControllerBase
{
    [HttpGet("v1/categorias")]
    public IActionResult ObterCategorias([FromServices] BlogDataContext context)
    {
        var categorias = context.Categorias.ToList();
        return Ok(categorias);
    }
}