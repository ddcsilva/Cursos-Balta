using Flunt.Validations;

namespace ListaTarefas.Domain.Commands.Contracts;

/// <summary>
/// Interface para ser implementada por todos os comandos.
/// </summary>
public interface ICommand : IValidatable
{
}