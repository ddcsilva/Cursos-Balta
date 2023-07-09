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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>().ToTable("Tarefas");
        modelBuilder.Entity<Tarefa>().Property(x => x.Id);
        modelBuilder.Entity<Tarefa>().Property(x => x.Titulo).HasMaxLength(120).HasColumnType("varchar(120)");
        modelBuilder.Entity<Tarefa>().Property(x => x.DataConclusao);
        modelBuilder.Entity<Tarefa>().Property(x => x.Usuario).HasMaxLength(120).HasColumnType("varchar(120)");
        modelBuilder.Entity<Tarefa>().Property(x => x.Concluida).HasColumnType("bit");
        modelBuilder.Entity<Tarefa>().HasIndex(x => x.Usuario);
    }
}