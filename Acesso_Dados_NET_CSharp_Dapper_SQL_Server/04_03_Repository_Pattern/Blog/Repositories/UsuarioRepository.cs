using System;
using System.Collections.Generic;
using Balta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UsuarioRepository
    {
        public IEnumerable<Usuario> GetAll()
        {
            using (var conexao = new SqlConnection(CONNECTION_STRING))
            {
                return conexao.GetAll<Usuario>();
            }
        }
    }
}