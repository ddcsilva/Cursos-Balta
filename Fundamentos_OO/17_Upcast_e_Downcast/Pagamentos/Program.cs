System.Console.WriteLine("Hello World");
var pessoa = new Pessoa();
var pessoaFisica = new PessoaFisica();
var pessoaJuridica = new PessoaJuridica();

pessoa = new PessoaFisica();
pessoa = new Pessoa();
pessoa = new PessoaJuridica();
pessoa = new Pessoa();

pessoaFisica = (PessoaFisica)pessoa;

public class Pessoa
{
    public string Nome { get; set; }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
}

public class PessoaJuridica : Pessoa
{
    public string CNPJ { get; set; }
}