var pessoaA = new Pessoa(1, "Danilo Silva");
var pessoaB = new Pessoa(1, "Danilo Silva");

Console.WriteLine(pessoaA == pessoaB);
Console.WriteLine(pessoaA.Id == pessoaB.Id);
Console.WriteLine(pessoaA.Equals(pessoaB));

public class Pessoa : IEquatable<Pessoa>
{
    public Pessoa(int id, string nome)
    {
        this.Id = id;
        this.Nome = nome;
    }

    public int Id { get; set; }
    public string Nome { get; set; }

    public bool Equals(Pessoa pessoa)
    {
        return Id == pessoa.Id;
    }
}