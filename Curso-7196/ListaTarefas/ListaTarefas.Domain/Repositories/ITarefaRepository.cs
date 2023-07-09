using ListaTarefas.Domain.Entities;

namespace ListaTarefas.Domain.Repositories;

/// <summary>
/// Interface para o repositório de tarefas.
/// </summary>
public interface ITarefaRepository
{
    void Criar(Tarefa tarefa);
    void Atualizar(Tarefa tarefa);

    Tarefa ObterPorId(Guid id, string usuario);
    IEnumerable<Tarefa> ObterTodasTarefas(string usuario);
    IEnumerable<Tarefa> ObterTodasTarefasConcluidas(string usuario);
    IEnumerable<Tarefa> ObterTodasTarefasNaoConcluidas(string usuario);
    IEnumerable<Tarefa> ObterPorPeriodo(string usuario, DateTime dataConclusao, bool concluida);
}