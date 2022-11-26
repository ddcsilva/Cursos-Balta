Console.WriteLine("Hello, World!");
var pagamento = new Pagamento();

// private, protected, internal e public
public class Pagamento
{
    protected DateTime Vencimento;

    private void Pagar() { }
}

public class PagamentoBoleto : Pagamento
{
    void Teste()
    {
        base.Vencimento = DateTime.Now;
    }
}