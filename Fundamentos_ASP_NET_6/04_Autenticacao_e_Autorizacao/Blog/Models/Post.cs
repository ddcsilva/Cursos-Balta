namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sumario { get; set; }
        public string Corpo { get; set; }
        public string Slug { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }

        public List<Tag> Tags { get; set; }
    }
}