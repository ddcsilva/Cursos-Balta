static void RealizarPagamento(double valor)
{
    System.Console.WriteLine($"Pago o valor de {valor}");
}

var pagar = new Pagamento.Pagar(RealizarPagamento);
pagar(35);

public class Pagamento
{
    public delegate void Pagar(double valor);
}