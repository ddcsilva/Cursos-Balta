using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Telas.TelasTag
{
    public static class TelaListTag
    {
        public static void Carregar()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            Listar();
            Console.ReadKey();
            TelaMenuTag.Carregar();
        }

        private static void Listar()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.GetAll();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Nome} ({item.Slug})");
        }
    }
}