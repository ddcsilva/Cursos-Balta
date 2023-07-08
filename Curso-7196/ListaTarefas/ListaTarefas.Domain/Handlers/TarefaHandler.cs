using Flunt.Notifications;
using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Commands.Contracts;
using ListaTarefas.Domain.Repositories;

namespace ListaTarefas.Domain.Handlers.Contracts;

public class TarefaHandler : Notifiable, IHandler<CriarTarefaCommand>
{
    private readonly ITarefaRepository _repository;

    public TarefaHandler(ITarefaRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CriarTarefaCommand command)
    {
        
    }
}