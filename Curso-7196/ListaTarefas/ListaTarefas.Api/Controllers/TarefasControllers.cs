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

    [HttpGet]
    [Route("concluidas")]
    public IEnumerable<Tarefa> ObterTarefasConcluidas([FromServices] ITarefaRepository repository)
    {
        return repository.ObterTodasTarefasConcluidas("danilo");
    }

    [HttpGet]
    [Route("nao-concluidas")]
    public IEnumerable<Tarefa> ObterTarefasNaoConcluidas([FromServices] ITarefaRepository repository)
    {
        return repository.ObterTodasTarefasNaoConcluidas("danilo");
    }

    [HttpGet]
    [Route("concluidas/hoje")]
    public IEnumerable<Tarefa> ObterTarefasConcluidasHoje([FromServices] ITarefaRepository repository)
    {
        return repository.ObterPorPeriodo("danilo", DateTime.Now.Date, true);
    }
    
    [HttpGet]
    [Route("nao-concluidas/hoje")]
    public IEnumerable<Tarefa> ObterTarefasNaoConcluidasHoje([FromServices] ITarefaRepository repository)
    {
        return repository.ObterPorPeriodo("danilo", DateTime.Now.Date, false);
    }

    [HttpGet]
    [Route("concluidas/amanha")]
    public IEnumerable<Tarefa> ObterTarefasConcluidasAmanha([FromServices] ITarefaRepository repository)
    {
        return repository.ObterPorPeriodo("danilo", DateTime.Now.Date.AddDays(1), true);
    }

    [HttpGet]
    [Route("nao-concluidas/amanha")]
    public IEnumerable<Tarefa> ObterTarefasNaoConcluidasAmanha([FromServices] ITarefaRepository repository)
    {
        return repository.ObterPorPeriodo("danilo", DateTime.Now.Date.AddDays(1), false);
    }

    [HttpPost]
    [Route("")]
    public GenericCommandResult CriarTarefa([FromBody] CriarTarefaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("")]
    public GenericCommandResult AtualizarTarefa([FromBody] AtualizarTarefaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("marcar-como-concluida")]
    public GenericCommandResult MarcarTarefaComoConcluida([FromBody] MarcarComoConcluidaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("marcar-como-nao-concluida")]
    public GenericCommandResult MarcarTarefaComoNaoConcluida([FromBody] MarcarComoNaoConcluidaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }
}