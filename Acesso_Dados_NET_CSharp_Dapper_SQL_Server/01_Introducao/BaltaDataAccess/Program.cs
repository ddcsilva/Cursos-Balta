using System;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=Ra170115!";

            using (var connection = new SqlConnection())
            {
                Console.WriteLine("Conectado!");
            }
        }
    }
}
