using System.Data.Common;
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
        try
        {
            var categorias = await context.Categorias.ToListAsync();
            return Ok(categorias);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensagem = $"Erro interno: {ex.Message}" });
        }
    }

    [HttpGet("v1/categorias/{id:int}")]
    public async Task<IActionResult> ObterCategoriaPorIdAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null) return NotFound();

            return Ok(categoria);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensagem = $"Erro interno: {ex.Message}" });
        }
    }

    [HttpPost("v1/categorias")]
    public async Task<IActionResult> AdicionarCategoriaAsync([FromBody] Categoria categoria, [FromServices] BlogDataContext context)
    {
        try
        {
            await context.Categorias.AddAsync(categoria);
            await context.SaveChangesAsync();

            return Created($"v1/categorias/{categoria.Id}", categoria);
        }
        catch (DbException ex)
        {
            return StatusCode(400, new { mensagem = $"Erro ao inserir categoria: {ex.Message}" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensagem = $"Erro interno: {ex.Message}" });
        }
    }

    [HttpPut("v1/categorias/{id:int}")]
    public async Task<IActionResult> AtualizarCategoriaAsync([FromRoute] int id, [FromBody] Categoria categoria, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoriaAtual = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoriaAtual == null) return NotFound();

            categoriaAtual.Nome = categoria.Nome;

            context.Categorias.Update(categoriaAtual);
            await context.SaveChangesAsync();

            return Ok(categoriaAtual);
        }
        catch (DbException ex)
        {
            return StatusCode(400, new { mensagem = $"Erro ao atualizar categoria: {ex.Message}" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensagem = $"Erro interno: {ex.Message}" });
        }
    }

    [HttpDelete("v1/categorias/{id:int}")]
    public async Task<IActionResult> RemoverCategoriaAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null) return NotFound();

            context.Categorias.Remove(categoria);
            await context.SaveChangesAsync();

            return NoContent();
        }
        catch (DbException ex)
        {
            return StatusCode(400, new { mensagem = $"Erro ao remover categoria: {ex.Message}" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { mensagem = $"Erro interno: {ex.Message}" });
        }
    }
}