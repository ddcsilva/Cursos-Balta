using Balta.NotifacaoContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            // SPOF - Ponto Único de Falha
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}