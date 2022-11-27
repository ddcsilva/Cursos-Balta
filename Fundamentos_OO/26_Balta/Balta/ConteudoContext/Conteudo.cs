namespace Balta.ConteudoContext
{
    // Conteúdo não deve ser instânciado
    public abstract class Conteudo
    {
        public Conteudo()
        {
            // SPOF - Ponto Único de Falha
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}