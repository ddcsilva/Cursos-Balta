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
                    [Usuario].*,
                    [Role].*
                FROM
                    [Usuario]
                    LEFT JOIN [UsuarioRole] ON [UsuarioRole].[UsuarioId] = [Usuario].[Id]
                    LEFT JOIN [Role] ON [UsuarioRole].[RoleId] = [Role].[Id]";

            var usuarios = new List<Usuario>();

            var items = _connection.Query<Usuario, Role, Usuario>(
                query,
                (usuario, role) =>
                {
                    var usr = usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                    if (usr == null)
                    {
                        usr = usuario;
                        if (role != null)
                            usr.Roles.Add(role);

                        usuarios.Add(usuario);
                    }
                    else
                    {
                        usr.Roles.Add(role);
                    }

                    return usuario;
                }, splitOn: "Id");
            return usuarios;
        }
    }
}