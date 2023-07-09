using System.Linq.Expressions;
using ListaTarefas.Domain.Entities;

namespace ListaTarefas.Domain.Queries;

public class TarefaQueries
{
    public static Expression<Func<Tarefa, bool>> ObterPorId(Guid id, string usuario)
    {
        return tarefa => tarefa.Id == id && tarefa.Usuario == usuario;
    }

    public static Expression<Func<Tarefa, bool>> ObterTodasTarefas(string usuario)
    {
        return tarefa => tarefa.Usuario == usuario;
    }

    public static Expression<Func<Tarefa, bool>> ObterTodasTarefasConcluidas(string usuario)
    {
        return tarefa => tarefa.Usuario == usuario && tarefa.Concluida;
    }

    public static Expression<Func<Tarefa, bool>> ObterTodasTarefasNaoConcluidas(string usuario)
    {
        return tarefa => tarefa.Usuario == usuario && !tarefa.Concluida;
    }

    public static Expression<Func<Tarefa, bool>> ObterPorPeriodo(string usuario, DateTime dataConclusao, bool concluida)
    {
        return tarefa => tarefa.Usuario == usuario && tarefa.DataConclusao.Date == dataConclusao.Date && tarefa.Concluida == concluida;
    }
}