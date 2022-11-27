using Balta.SharedContext;

namespace Balta.AssinaturaContext
{
    public class Usuario : Base
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}