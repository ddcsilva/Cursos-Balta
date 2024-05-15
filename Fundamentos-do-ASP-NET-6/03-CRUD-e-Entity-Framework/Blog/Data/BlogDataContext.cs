using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data;

public class BlogDataContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    // Método para configurar o banco de dados
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=0nd3m@nd;TrustServerCertificate=True");

    // Método para mapear as entidades
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoriaMap());
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new PostMap());
    }
}