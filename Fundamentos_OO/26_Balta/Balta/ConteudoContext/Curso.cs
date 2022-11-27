namespace Balta.ConteudoContext
{
    public class Curso : Conteudo
    {
        public Curso()
        {
            Modulos = new List<Modulo>();
        }

        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
    }

    public class Modulo
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public IList<Aula> Aulas { get; set; }
    }

    public class Aula
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
    }
}