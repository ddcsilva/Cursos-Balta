using ListaTarefas.Domain.Commands;

namespace ListaTarefas.Tests.CommandTests;

/// <summary>
/// Classe de testes para o comando CriarTarefaCommand.
/// </summary>
public class CriarTarefaCommandTests
{
    private readonly CriarTarefaCommand _commandInvalido = new("", DateTime.Now, "");
    private readonly CriarTarefaCommand _commandValido = new("Titulo da tarefa", DateTime.Now, "Usuario");

    public CriarTarefaCommandTests()
    {
        _commandInvalido.Validate();
        _commandValido.Validate();
    }

    [Fact]
    public void Dado_um_comando_invalido()
    {
        Assert.False(_commandInvalido.Valid);
    }

    [Fact]
    public void Dado_um_comando_valido()
    {
        Assert.True(_commandValido.Valid);
    }
}