namespace Balta.NotifacaoContext
{
    public sealed class Notificacao
    {
        public Notificacao() { }

        public Notificacao(string propriedade, string mensagem)
        {
            this.Propriedade = propriedade;
            this.Mensagem = mensagem;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
    }
}