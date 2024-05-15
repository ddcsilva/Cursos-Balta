using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers;

[ApiController]
public class CategoriasController : ControllerBase
{
    [HttpGet("v1/categorias")]
    public async Task<IActionResult> ObterCategoriasAsync([FromServices] BlogDataContext context)
    {
        var categorias = await context.Categorias.ToListAsync();
        return Ok(categorias);
    }
}