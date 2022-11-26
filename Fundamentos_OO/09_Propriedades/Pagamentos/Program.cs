Console.WriteLine("Hello, World!");
var pagamento = new Pagamento();
pagamento.NumerBoleto = "123456";
pagamento.DataPagamento = DateTime.Now;
System.Console.WriteLine(pagamento.DataPagamento);

public class Pagamento
{
    // Propriedades
    public string NumerBoleto;

    public DateTime Teste { get; private set; }

    public DateTime Vencimento { get; set; }

    private DateTime dataPagamento;
    public DateTime DataPagamento
    {
        get
        {
            System.Console.WriteLine("Lendo o valor");
            return dataPagamento;
        }
        set
        {
            System.Console.WriteLine("Atribuindo valor");
            dataPagamento = value;
        }
    }

    Endereco enderecoPagamento;

    // Métodos
    void Pagar() { }
}

public class Endereco
{
    string Cep;
}