using ListaTarefas.Domain.Entities;
using ListaTarefas.Domain.Repositories;

namespace ListaTarefas.Tests.Repositories;

public class FakeTarefaRepository : ITarefaRepository
{
    public void Criar(Tarefa tarefa)
    {
        
    }

    public void Atualizar(Tarefa tarefa)
    {
        
    }

    public Tarefa ObterPorId(Guid id, string usuario)
    {
        return new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario");
    }

    public IEnumerable<Tarefa> ObterTodasTarefas(string usuario)
    {
        var tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        return tarefas;
    }

    public IEnumerable<Tarefa> ObterTodasTarefasConcluidas(string usuario)
    {
        var tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        return tarefas;
    }

    public IEnumerable<Tarefa> ObterTodasTarefasNaoConcluidas(string usuario)
    {
        var tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        return tarefas;
    }

    public IEnumerable<Tarefa> ObterPorPeriodo(string usuario, DateTime dataConclusao, bool concluida)
    {
        var tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        tarefas.Add(new Tarefa("Titulo da tarefa", DateTime.Now, "Usuario"));
        return tarefas;
    }
}