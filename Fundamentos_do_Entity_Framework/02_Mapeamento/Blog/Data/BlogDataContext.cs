using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // Banco de Dados em Memória
    public class BlogDataContext : DbContext
    {
        // As tabelas do Banco de Dados
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=Ra170115!");
    }
}