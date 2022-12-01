using System.Collections.Generic;
using Balta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UsuarioRepository
    {
        private readonly SqlConnection _connection;

        public UsuarioRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<Usuario> GetAll()
            => _connection.GetAll<Usuario>();

        public Usuario Get(int id)
            => _connection.Get<Usuario>(id);

        public void Create(Usuario usuario)
            => _connection.Insert<Usuario>(usuario);
    }
}