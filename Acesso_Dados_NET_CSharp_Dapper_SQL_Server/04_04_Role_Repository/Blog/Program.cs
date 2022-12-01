using System;
using Balta.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
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
            GetAllUsuarios(connection);
            GetAllRoles(connection);
            // LerUsuario(1);
            // CriarUsuario();
            // AtualizarUsuario(2);
            // ExcluirUsuario(2);
            connection.Close();
        }

        public static void GetAllUsuarios(SqlConnection connection)
        {
            var repository = new UsuarioRepository(connection);
            var usuarios = repository.GetAll();

            foreach (var usuario in usuarios)
                Console.WriteLine(usuario.Nome);
        }

        public static void GetAllRoles(SqlConnection connection)
        {
            var repository = new RoleRepository(connection);
            var roles = repository.GetAll();

            foreach (var role in roles)
                Console.WriteLine(role.Nome);
        }
    }
}
