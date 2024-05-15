using Blog.Data;
using Blog.Models;
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

    [HttpGet("v1/categorias/{id:int}")]
    public async Task<IActionResult> ObterCategoriaPorIdAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

        if (categoria == null) return NotFound();

        return Ok(categoria);
    }

    [HttpPost("v1/categorias")]
    public async Task<IActionResult> AdicionarCategoriaAsync([FromBody] Categoria categoria, [FromServices] BlogDataContext context)
    {
        await context.Categorias.AddAsync(categoria);
        await context.SaveChangesAsync();

        return CreatedAtAction($"v1/categorias/{categoria.Id}", categoria);
    }

    [HttpPut("v1/categorias/{id:int}")]
    public async Task<IActionResult> AtualizarCategoriaAsync([FromRoute] int id, [FromBody] Categoria categoria, [FromServices] BlogDataContext context)
    {
        var categoriaExistente = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

        if (categoriaExistente == null) return NotFound();

        categoriaExistente.Nome = categoria.Nome;
        categoriaExistente.Slug = categoria.Slug;

        context.Categorias.Update(categoriaExistente);
        await context.SaveChangesAsync();

        return Ok(categoria);
    }

    [HttpDelete("v1/categorias/{id:int}")]
    public async Task<IActionResult> RemoverCategoriaAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

        if (categoria == null) return NotFound();

        context.Categorias.Remove(categoria);
        await context.SaveChangesAsync();

        return Ok(categoria);
    }
}