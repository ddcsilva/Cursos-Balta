using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // Banco de Dados em Memória
    public class BlogDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=Ra170115!");
    }
}