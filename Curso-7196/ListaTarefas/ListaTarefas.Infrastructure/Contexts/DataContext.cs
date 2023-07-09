using ListaTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefas.Infrastructure.Contexts;

/// <summary>
/// Classe de contexto para o banco de dados.
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Tarefa> Tarefas { get; set; }
}