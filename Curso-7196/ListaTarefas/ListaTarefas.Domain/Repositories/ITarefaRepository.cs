using ListaTarefas.Domain.Entities;

namespace ListaTarefas.Domain.Repositories;

/// <summary>
/// Interface para o repositório de tarefas.
/// </summary>
public interface ITarefaRepository
{
    void Criar(Tarefa tarefa);
    void Atualizar(Tarefa tarefa);
}