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
            using var context = new BlogDataContext();

            // context.Users.Add(new User
            // {
            //     Bio = "Um dev qualquer",
            //     Email = "danilo.silva@msn.com",
            //     Image = "https://",
            //     Name = "Danilo Silva",
            //     PasswordHash = "1234",
            //     Slug = "danilo-silva"
            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = "Olá",
                Category = new Category
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                //LastUpdateDate = 
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir",
                Tags = null,
                Title = "Meu artigo"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
