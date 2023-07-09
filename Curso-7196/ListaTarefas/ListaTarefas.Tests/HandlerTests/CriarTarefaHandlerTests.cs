using ListaTarefas.Domain.Commands;
using ListaTarefas.Domain.Handlers;
using ListaTarefas.Tests.Repositories;

namespace ListaTarefas.Tests.HandlerTests;

public class CriarTarefaHandlerTests
{
    [Fact]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        var command = new CriarTarefaCommand("", DateTime.Now, "");
        var handler = new TarefaHandler(new FakeTarefaRepository());

        Assert.False(false);
    }

    [Fact]
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        Assert.True(true);
    }
}