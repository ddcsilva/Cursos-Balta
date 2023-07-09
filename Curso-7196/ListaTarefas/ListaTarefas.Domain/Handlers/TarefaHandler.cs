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
public class TarefaHandler : 
    Notifiable, 
    IHandler<CriarTarefaCommand>, 
    IHandler<AtualizarTarefaCommand>,
    IHandler<MarcarComoConcluidaCommand>,
    IHandler<MarcarComoNaoConcluidaCommand>
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

    public ICommandResult Handle(AtualizarTarefaCommand command)
    {
        command.Validate();

        if (command.Invalid)
            return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

        var tarefa = _repository.ObterPorId(command.Id, command.Usuario);

        tarefa.AlterarTitulo(command.Titulo);

        _repository.Atualizar(tarefa);

        return new GenericCommandResult(true, "Tarefa atualizada com sucesso!", tarefa);
    }

    public ICommandResult Handle(MarcarComoConcluidaCommand command)
    {
        command.Validate();

        if (command.Invalid)
            return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

        var tarefa = _repository.ObterPorId(command.Id, command.Usuario);

        tarefa.MarcarComoConcluida();

        _repository.Atualizar(tarefa);

        return new GenericCommandResult(true, "Tarefa marcada como concluída!", tarefa);
    }

    public ICommandResult Handle(MarcarComoNaoConcluidaCommand command)
    {
        command.Validate();

        if (command.Invalid)
            return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

        var tarefa = _repository.ObterPorId(command.Id, command.Usuario);

        tarefa.MarcarComoNaoConcluida();

        _repository.Atualizar(tarefa);

        return new GenericCommandResult(true, "Tarefa marcada como não concluída!", tarefa);
    }
}