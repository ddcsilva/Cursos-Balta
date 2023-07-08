using ListaTarefas.Domain.Commands.Contracts;

namespace ListaTarefas.Domain.Commands;

public class GenericCommandResult : ICommandResult
{
    public bool Sucesso { get; set; }
    public string? Mensagem { get; set; }
    public object? Dados { get; set; }
}
