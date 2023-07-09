using Flunt.Notifications;
using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Commands.Contracts;
using ListaTarefas.Domain.Entities;
using ListaTarefas.Domain.Handlers.Contracts;
using ListaTarefas.Domain.Repositories;

namespace ListaTarefas.Domain.Handlers;

/// <summary>
/// Classe Handler para criar uma tarefa.
/// </summary>
public class TarefaHandler : Notifiable, IHandler<CriarTarefaCommand>
{
    private readonly ITarefaRepository _repository;

    public TarefaHandler(ITarefaRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CriarTarefaCommand command)
    {
        command.Validate();

        if (command.Invalid)
            return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

        var tarefa = new Tarefa(command.Titulo, command.DataConclusao, command.Usuario);

        _repository.Criar(tarefa);

        return new GenericCommandResult(true, "Tarefa salva com sucesso!", tarefa);
    }
}