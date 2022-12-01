using Dapper.Contrib.Extensions;

namespace Balta.Models
{
    [Table("[Usuario]")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Biografia { get; set; }
        public string Imagem { get; set; }
        public string Slug { get; set; }
    }
}