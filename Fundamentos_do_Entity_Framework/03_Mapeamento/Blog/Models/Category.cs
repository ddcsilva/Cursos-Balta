namespace Blog.Models
{
    // Representação da tabela Category do BD
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public IList<Post> Posts { get; set; }
    }
}