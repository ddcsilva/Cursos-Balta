using ListaTarefas.Domain.Entities;
using ListaTarefas.Domain.Queries;

namespace ListaTarefas.Tests.QueriesTests;

public class TarefaQueriesTests
{
    private List<Tarefa> _tarefas = new();

    public TarefaQueriesTests()
    {
        _tarefas = new List<Tarefa>
        {
            new Tarefa("Tarefa 1", DateTime.Now, "Danilo_Araujo"),
            new Tarefa("Tarefa 2", DateTime.Now, "Rosana_Silva"),
            new Tarefa("Tarefa 3", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 4", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 5", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 6", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 7", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 8", DateTime.Now, "Danilo"),
            new Tarefa("Tarefa 9", DateTime.Now, "Raquel"),
            new Tarefa("Tarefa 10", DateTime.Now, "Danilo")
        };
    }

    [Fact]
    public void Dado_a_consulta_deve_retornar_tarefas_apenas_do_usuario_danilo()
    {
        var result = _tarefas.AsQueryable().Where(TarefaQueries.ObterTodasTarefas("Danilo")).ToList();
        Assert.Equal(7, result.Count);
    }
}