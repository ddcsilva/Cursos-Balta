namespace Balta.ConteudoContext
{
    // Conteúdo não deve ser instânciado
    public abstract class Conteudo
    {
        public Conteudo(string titulo, string url)
        {
            // SPOF - Ponto Único de Falha
            this.Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.Url = url;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}