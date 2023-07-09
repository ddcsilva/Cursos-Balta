using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Handlers;
using ListaTarefas.Tests.Repositories;

namespace ListaTarefas.Tests.HandlerTests;

public class CriarTarefaHandlerTests
{
    private readonly CriarTarefaCommand _commandInvalido = new("", DateTime.Now, "");
    private readonly CriarTarefaCommand _commandValido = new("Titulo da tarefa", DateTime.Now, "Usuario");
    private readonly TarefaHandler _handler = new(new FakeTarefaRepository());
    private GenericCommandResult _result = new();

    [Fact]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        _result = (GenericCommandResult)_handler.Handle(_commandInvalido);
        Assert.False(_result.Sucesso);
    }

    [Fact]
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        _result = (GenericCommandResult)_handler.Handle(_commandValido);
        Assert.True(_result.Sucesso);
    }
}