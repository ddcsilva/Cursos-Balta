using System;
using Balta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Ra170115!";

        static void Main(string[] args)
        {
            LerUsuarios();
        }

        public static void LerUsuarios()
        {
            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                var usuarios = conexao.GetAll<Usuario>();

                foreach (var usuario in usuarios)
                {
                    Console.WriteLine(usuario.Nome);
                }
            }
        }
    }
}
