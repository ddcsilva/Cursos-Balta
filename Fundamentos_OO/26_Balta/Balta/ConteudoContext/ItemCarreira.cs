using Balta.NotifacaoContext;
using Balta.SharedContext;

namespace Balta.ConteudoContext
{
    public class ItemCarreira : Base
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso curso)
        {
            if (curso == null)
                AdicionaNotificacao(new Notificacao("Curso", "Curso Inválido"));

            this.Ordem = ordem;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}