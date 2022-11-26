System.Console.WriteLine("Hello World");

public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
        // Executar algo
    }
}

public class PagamentoCartaoCredito : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoBoleto : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoGooglePay : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public interface IPagamento
{
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}