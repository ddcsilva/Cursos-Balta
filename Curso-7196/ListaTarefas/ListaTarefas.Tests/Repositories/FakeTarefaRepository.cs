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
}