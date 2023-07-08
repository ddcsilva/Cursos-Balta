using ListaTarefas.Domain.Entities;

namespace ListaTarefas.Domain.Repositories;

public interface ITarefaRepository
{
    void Criar(Tarefa tarefa);
    void Atualizar(Tarefa tarefa);
}