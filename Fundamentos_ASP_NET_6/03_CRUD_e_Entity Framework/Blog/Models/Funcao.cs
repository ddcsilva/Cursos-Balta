namespace Blog.Models
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }

        public IList<Usuario> Usuarios { get; set; }
    }
}