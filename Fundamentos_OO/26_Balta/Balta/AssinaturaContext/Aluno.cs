using Balta.NotifacaoContext;
using Balta.SharedContext;

namespace Balta.AssinaturaContext
{
    public class Aluno : Base
    {
        public Aluno()
        {
            this.Assinaturas = new List<Assinatura>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set; }
        public bool Premium => Assinaturas.Any(x => !x.Inativo);

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (Premium)
            {
                AdicionaNotificacao(new Notificacao("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            Assinaturas.Add(assinatura);
        }
    }
}