using System.Linq;
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
                /* Create - NO TRACKING */
                /* Defini os novos dados a serem persistidos */
                // var tag = new Tag { Name = ".NET", Slug = "aspnet" };
                /* Salva na Memória */
                // context.Tags.Add(tag);
                /* Persiste no Banco de Dados */
                // context.SaveChanges();

                /* ----------------------- */

                /* Update */
                /* Busca o item no Banco de Dados */
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                /* Defini os dados a serem atualizados */
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                /* Atualiza na Memória */
                // context.Update(tag);
                /* Persiste no Banco de Dados */
                // context.SaveChanges();

                /* ----------------------- */

                /* Delete */
                /* Busca o item no Banco de Dados */
                var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                /* Exclui na Memória */
                context.Remove(tag);
                /* Persiste no Banco de Dados */
                context.SaveChanges();
            }
        }
    }
}
