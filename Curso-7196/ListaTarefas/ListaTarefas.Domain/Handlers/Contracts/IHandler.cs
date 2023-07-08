using ListaTarefas.Domain.Commands.Contracts;

namespace ListaTarefas.Domain.Handlers.Contracts;

/// <summary>
/// Interface utilizada para padronizar os handlers.
/// </summary>
public interface IHandler<T> where T : ICommand
{
    ICommandResult Handle(T command);
}