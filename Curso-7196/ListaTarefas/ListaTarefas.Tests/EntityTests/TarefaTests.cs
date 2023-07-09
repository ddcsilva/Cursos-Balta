using ListaTarefas.Domain.Entities;

namespace ListaTarefas.Tests.EntityTests;

public class TarefaTests
{
    private readonly Tarefa _tarefaValida = new("Titulo da tarefa", DateTime.Now, "Usuario");

    [Fact]
    public void Dado_uma_nova_tarefa_o_mesmo_nao_pode_ser_concluido()
    {
        Assert.Equal(_tarefaValida.Concluida, false);
    }
}