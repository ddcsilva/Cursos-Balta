using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // Banco de Dados em Memória
    public class BlogDataContext : DbContext
    {
        // As tabelas do Banco de Dados
        public DbSet<Category> Categories { get; set; }
    }
}