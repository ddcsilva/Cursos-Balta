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
        {
            usuario.Id = 0;
            _connection.Insert<Usuario>(usuario);
        }

        public void Update(Usuario usuario)
        {
            if (usuario.Id != 0)
                _connection.Update<Usuario>(usuario);
        }

        public void Delete(Usuario usuario)
        {
            if (usuario.Id != 0)
                _connection.Delete<Usuario>(usuario);
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var usuario = _connection.Get<Usuario>(id);
            _connection.Delete<Usuario>(usuario);
        }
    }
}