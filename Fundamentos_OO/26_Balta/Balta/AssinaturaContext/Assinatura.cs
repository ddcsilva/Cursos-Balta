using Balta.SharedContext;

namespace Balta.AssinaturaContext
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool Inativo => DataFinal <= DateTime.Now;
    }
}