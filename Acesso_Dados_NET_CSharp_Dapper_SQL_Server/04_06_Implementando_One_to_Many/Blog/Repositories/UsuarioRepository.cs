using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        private readonly SqlConnection _connection;

        public UsuarioRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Usuario> GetAllWithRoles()
        {
            var query = @"
                SELECT
                    [User].*,
                    [Role].*
                FROM
                    [User]
                    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var usuarios = new List<Usuario>();

            var items = _connection.Query<Usuario, Role, Usuario>(
                query,
                (user, role) =>
                {
                    var usuario = usuarios.FirstOrDefault(x => x.Id == user.Id);
                    if (usuario == null)
                    {
                        usuario = user;
                        usuario.Roles.Add(role);
                        usuarios.Add(usuario);
                    }
                    else
                    {
                        usuario.Roles.Add(role);
                    }

                    return user;
                }, splitOn: "Id");
            return usuarios;
        }
    }
}