namespace Balta.NotifacaoContext
{
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes { get; set; }

        public void Adicionar(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AdicionarLista(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
    }
}