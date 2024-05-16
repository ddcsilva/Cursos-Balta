using System.Data.Common;
using Blog.Data;
using Blog.Extensions;
using Blog.Models;
using Blog.ViewModels;
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
            return Ok(new RetornoViewModel<List<Categoria>>(categorias));
        }
        catch (Exception)
        {
            return StatusCode(500, new RetornoViewModel<string>([$"Falha interna no servidor."]));
        }
    }

    [HttpGet("v1/categorias/{id:int}")]
    public async Task<IActionResult> ObterCategoriaPorIdAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null) return NotFound(new RetornoViewModel<Categoria>([$"Categoria com id {id} não encontrada."]));

            return Ok(new RetornoViewModel<Categoria>(categoria));
        }
        catch (Exception)
        {
            return StatusCode(500, new RetornoViewModel<string>([$"Falha interna no servidor."]));
        }
    }

    [HttpPost("v1/categorias")]
    public async Task<IActionResult> AdicionarCategoriaAsync([FromBody] EdicaoCategoriaViewModel categoriaViewModel, [FromServices] BlogDataContext context)
    {
        if (!ModelState.IsValid) return BadRequest(new RetornoViewModel<Categoria>(ModelState.ObterErros()));

        try
        {
            var categoria = new Categoria
            {
                Nome = categoriaViewModel.Nome,
                Slug = categoriaViewModel.Slug.ToLower()
            };

            await context.Categorias.AddAsync(categoria);
            await context.SaveChangesAsync();

            return Created($"v1/categorias/{categoria.Id}", new RetornoViewModel<Categoria>(categoria));
        }
        catch (DbException)
        {
            return StatusCode(400, new RetornoViewModel<string>([$"Erro ao adicionar categoria."]));
        }
        catch (Exception)
        {
            return StatusCode(500, new RetornoViewModel<string>([$"Falha interna no servidor."]));
        }
    }

    [HttpPut("v1/categorias/{id:int}")]
    public async Task<IActionResult> AtualizarCategoriaAsync([FromRoute] int id, [FromBody] EdicaoCategoriaViewModel categoriaViewModel, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoriaAtual = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoriaAtual == null) return NotFound(new RetornoViewModel<Categoria>([$"Categoria com id {id} não encontrada."]));

            categoriaAtual.Nome = categoriaViewModel.Nome;
            categoriaAtual.Slug = categoriaViewModel.Slug;

            context.Categorias.Update(categoriaAtual);
            await context.SaveChangesAsync();

            return Ok(new RetornoViewModel<Categoria>(categoriaAtual));
        }
        catch (DbException)
        {
            return StatusCode(400, new RetornoViewModel<string>([$"Erro ao atualizar categoria."]));
        }
        catch (Exception)
        {
            return StatusCode(500, new RetornoViewModel<string>([$"Falha interna no servidor."]));
        }
    }

    [HttpDelete("v1/categorias/{id:int}")]
    public async Task<IActionResult> RemoverCategoriaAsync([FromRoute] int id, [FromServices] BlogDataContext context)
    {
        try
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null) return NotFound(new RetornoViewModel<Categoria>([$"Categoria com id {id} não encontrada."]));

            context.Categorias.Remove(categoria);
            await context.SaveChangesAsync();

            return Ok(new RetornoViewModel<Categoria>(categoria));
        }
        catch (DbException)
        {
            return StatusCode(400, new RetornoViewModel<string>([$"Erro ao remover categoria."]));
        }
        catch (Exception)
        {
            return StatusCode(500, new RetornoViewModel<string>([$"Falha interna no servidor."]));
        }
    }
}