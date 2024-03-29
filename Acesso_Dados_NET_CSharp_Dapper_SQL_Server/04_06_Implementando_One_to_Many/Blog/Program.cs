﻿using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Ra170115!";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            // GetAllUsuarios(connection);
            GetlAllUsuariosWithRoles(connection);
            // GetAllRoles(connection);
            // GetAllTags(connection);
            // CriarUsuario(connection);
            // LerUsuario(1);
            // CriarUsuario();
            // AtualizarUsuario(2);
            // ExcluirUsuario(2);
            connection.Close();
        }

        private static void CriarUsuario(SqlConnection connection)
        {
            var usuario = new Usuario
            {
                Biografia = "biografia",
                Email = "email@teste.com",
                Imagem = "imagem",
                Nome = "nome",
                Slug = "slug",
                Senha = "hash"
            };

            var repository = new Repository<Usuario>(connection);
            repository.Create(usuario);
        }

        public static void GetAllUsuarios(SqlConnection connection)
        {
            var repository = new Repository<Usuario>(connection);
            var usuarios = repository.GetAll();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Nome);

                foreach (var role in usuario.Roles)
                {
                    Console.WriteLine($" - {role.Nome}");
                }
            }
        }

        public static void GetAllRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var roles = repository.GetAll();

            foreach (var role in roles)
                Console.WriteLine(role.Nome);
        }

        public static void GetAllTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var tags = repository.GetAll();

            foreach (var tag in tags)
                Console.WriteLine(tag.Nome);
        }

        private static void GetlAllUsuariosWithRoles(SqlConnection connection)
        {
            var repository = new UsuarioRepository(connection);
            var usuarios = repository.GetAllWithRoles();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Email);
                foreach (var role in usuario.Roles) Console.WriteLine($" - {role.Slug}");
            }
        }
    }
}
