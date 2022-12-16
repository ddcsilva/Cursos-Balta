namespace Todo.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluido { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}