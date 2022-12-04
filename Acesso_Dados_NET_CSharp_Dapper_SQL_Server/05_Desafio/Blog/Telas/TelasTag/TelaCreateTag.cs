using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Telas.TelasTag
{
    public static class TelaCreateTag
    {
        public static void Carregar()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Nome = nome,
                Slug = slug
            });

            Console.ReadKey();
            TelaMenuTag.Carregar();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}