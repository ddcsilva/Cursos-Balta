using Balta.SharedContext;

namespace Balta.AssinaturaContext
{
    public class Aluno : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
    }
}