using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
public class CategoriasController : ControllerBase
{
    [HttpGet("categorias")]
    public IActionResult ObterCategorias([FromServices] BlogDataContext context)
    {
        var categorias = context.Categorias.ToList();
        return Ok(categorias);
    }
}