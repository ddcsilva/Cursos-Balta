namespace Balta.ConteudoContext
{
    public class ItemCarreira
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso curso)
        {
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