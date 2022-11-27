namespace Balta.ConteudoContext
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
            : base(titulo, url)
        {
            this.Itens = new List<ItemCarreira>();
        }

        public IList<ItemCarreira> Itens { get; set; }
        public int TotalCursos => Itens.Count; // Expression Body
    }
}