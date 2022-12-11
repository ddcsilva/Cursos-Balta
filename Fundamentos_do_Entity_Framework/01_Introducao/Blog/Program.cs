using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

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
                // var tag2 = new Tag { Name = ".NET Core", Slug = "aspnet-core" };
                /* Salva na Memória */
                // context.Tags.Add(tag);
                // context.Tags.Add(tag2);
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
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                /* Exclui na Memória */
                // context.Remove(tag);
                /* Persiste no Banco de Dados */
                // context.SaveChanges();

                var tags = context
                    .Tags /* Só até aqui não executa no banco */
                    .AsNoTracking() /* Desabilita os Metadados (Usado só em Delete e Update) */
                    .ToList(); /* Força a execução no banco (Sempre no final) */

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
