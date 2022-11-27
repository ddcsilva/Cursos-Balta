namespace Balta.NotifacaoContext
{
    public abstract class Notificavel
    {
        public Notificavel()
        {
            this.Notificacoes = new List<Notificacao>();
        }

        public List<Notificacao> Notificacoes { get; set; }

        public void AdicionaNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AdicionaNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }

        public bool Invalido => Notificacoes.Any();
    }
}