Console.WriteLine("Hello, World!");
var pagamentoBoleto = new PagamentoBoleto();
pagamentoBoleto.Pagar();
pagamentoBoleto.Vencimento = DateTime.Now;
pagamentoBoleto.NumeroBoleto = "1234";

var pagamento = new Pagamento();
pagamento.ToString();

class Pagamento 
{
    // Propriedades
    public DateTime Vencimento;

    // Métodos
    public virtual void Pagar() {}
}

class PagamentoBoleto : Pagamento
{
    public string NumeroBoleto;

    public override void Pagar()
    {
        // Regra do Boleto
    }

    public override string ToString()
    {
        return Vencimento.ToString("dd/MM/yyyy");
    }
}

class PagamentoCartaoCredito : Pagamento 
{
    public string Numero;

    public override void Pagar()
    {
        // Regra do Cartão de Crédito
    }
}