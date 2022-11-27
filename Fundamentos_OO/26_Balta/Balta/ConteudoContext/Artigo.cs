using Balta.NotifacaoContext;

namespace Balta.ConteudoContext
{
    public class Artigo : Conteudo
    {
        public IList<Notificacao> Notificacoes { get; set; }
        public Artigo(string titulo, string url)
            : base(titulo, url)
        {

        }
    }
}