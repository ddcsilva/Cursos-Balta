using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                var tag = new Tag { Name = ".NET", Slug = "aspnet" };
                // Salva na Memória
                context.Tags.Add(tag);
                // Persiste no Banco de Dados
                context.SaveChanges();
            }
        }
    }
}
