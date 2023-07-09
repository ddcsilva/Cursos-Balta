using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Entities;
using ListaTarefas.Domain.Handlers;
using ListaTarefas.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListaTarefas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public IEnumerable<Tarefa> ObterTodasTarefas([FromServices] ITarefaRepository repository)
    {
        return repository.ObterTodasTarefas("danilo");
    }

    [HttpPost]
    [Route("")]
    public GenericCommandResult CriarTarefa([FromBody] CriarTarefaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }
}