System.Console.WriteLine("Hello World");

public class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {

    }
}

public class PagamentoCartaoCredito : IPagamento
{
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {

    }
}

public interface IPagamento
{
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}