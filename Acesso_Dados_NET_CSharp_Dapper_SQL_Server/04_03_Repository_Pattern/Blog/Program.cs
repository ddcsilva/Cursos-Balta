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
            // LerUsuarios();
            // LerUsuario(1);
            // CriarUsuario();
            // AtualizarUsuario(2);
            // ExcluirUsuario(2);
        }

        public static void LerUsuarios()
        {
            var repository = new UsuarioRepository();
            var usuarios = repository.GetAll();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Nome);
            }
        }

        public static void LerUsuario(int id)
        {
            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                var usuario = conexao.Get<Usuario>(id);
                Console.WriteLine(usuario.Nome);
            }
        }

        public static void CriarUsuario()
        {
            var usuario = new Usuario()
            {
                Nome = "Rosana Silva",
                Email = "rosana.silva1144@gmail.com",
                Senha = "HASH",
                Biografia = "Uma grande Pedagoga",
                Imagem = "https://",
                Slug = "rosana-silva"
            };

            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                var linhasAfetadas = conexao.Insert<Usuario>(usuario);
                Console.WriteLine("Cadastro realizado com sucesso!");
            }

            LerUsuarios();
        }

        public static void AtualizarUsuario(int id)
        {
            var usuario = new Usuario()
            {
                Id = id,
                Nome = "Rosana da Cruz Silva",
                Email = "rosana.silva1144@gmail.com",
                Senha = "HASH",
                Biografia = "Uma grande Pedagoga",
                Imagem = "https://",
                Slug = "rosana-silva"
            };

            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                var linhasAfetadas = conexao.Update<Usuario>(usuario);
                Console.WriteLine("Atualização realizada com sucesso!");
            }

            LerUsuarios();
        }

        public static void ExcluirUsuario(int id)
        {
            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                var usuario = conexao.Get<Usuario>(id);
                conexao.Delete<Usuario>(usuario);
                Console.WriteLine("Exclusão realizada com sucesso!");
            }

            LerUsuarios();
        }
    }
}
