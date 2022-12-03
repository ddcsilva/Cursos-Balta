using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        private readonly SqlConnection _connection;

        public UsuarioRepository(SqlConnection connection) : base(connection)
            => _connection = connection;
    }
}