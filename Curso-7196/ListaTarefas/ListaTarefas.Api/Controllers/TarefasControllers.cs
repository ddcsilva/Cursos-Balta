using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ListaTarefas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public GenericCommandResult CriarTarefa([FromBody] CriarTarefaCommand command, [FromServices] TarefaHandler handler)
    {
        command.Usuario = "danilo";
        return (GenericCommandResult)handler.Handle(command);
    }
}