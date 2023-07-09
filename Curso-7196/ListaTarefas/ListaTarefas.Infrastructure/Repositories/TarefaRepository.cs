using ListaTarefas.Domain.Entities;
using ListaTarefas.Domain.Queries;
using ListaTarefas.Domain.Repositories;
using ListaTarefas.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefas.Infrastructure.Repositories;

/// <summary>
/// Classe responsável por implementar os métodos de acesso a dados da entidade Tarefa.
/// </summary>
public class TarefaRepository : ITarefaRepository
{
    private readonly DataContext _context;

    public TarefaRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Tarefa> ObterTodasTarefas(string usuario)
    {
        return _context.Tarefas.AsNoTracking().Where(TarefaQueries.ObterTodasTarefas(usuario)).OrderBy(x => x.DataConclusao);
    }

    public IEnumerable<Tarefa> ObterTodasTarefasConcluidas(string usuario)
    {
        return _context.Tarefas.AsNoTracking().Where(TarefaQueries.ObterTodasTarefasConcluidas(usuario)).OrderBy(x => x.DataConclusao);
    }

    public IEnumerable<Tarefa> ObterTodasTarefasNaoConcluidas(string usuario)
    {
        return _context.Tarefas.AsNoTracking().Where(TarefaQueries.ObterTodasTarefasNaoConcluidas(usuario)).OrderBy(x => x.DataConclusao);
    }

    public IEnumerable<Tarefa> ObterPorPeriodo(string usuario, DateTime dataConclusao, bool concluida)
    {
        return _context.Tarefas.AsNoTracking().Where(TarefaQueries.ObterPorPeriodo(usuario, dataConclusao, concluida)).OrderBy(x => x.DataConclusao);
    }

    public Tarefa ObterPorId(Guid id, string usuario)
    {
        return _context.Tarefas.AsNoTracking().FirstOrDefault(TarefaQueries.ObterPorId(id, usuario));
    }

    public void Criar(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
    }

    public void Atualizar(Tarefa tarefa)
    {
        _context.Entry(tarefa).State = EntityState.Modified;
        _context.SaveChanges();
    }
}