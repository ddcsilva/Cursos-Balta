using Balta.SharedContext;

namespace Balta.ConteudoContext
{
    // Conteúdo não deve ser instânciado
    public abstract class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {
            this.Titulo = titulo;
            this.Url = url;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}