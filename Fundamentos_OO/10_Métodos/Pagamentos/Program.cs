var pagamento = new Pagamento(DateTime.Now);
pagamento.Pagar("123");

var pagamentoCartao = new PagamentoCartao(DateTime.Now);
pagamentoCartao.Pagar("123");

public class Pagamento
{
    public DateTime DataPagamento { get; set; }

    public Pagamento() { }

    public Pagamento(DateTime dataPagamento)
    {
        System.Console.WriteLine("Iniciando o Pagamento");
        DataPagamento = DateTime.Now;
    }

    // Sobrecarga de Métodos
    public virtual void Pagar(string numero)
    {
        System.Console.WriteLine("Pagar");
    }
    void Pagar(string numero, DateTime dataVencimento) { }
    void Pagar(string numero, DateTime dataVencimento, bool pagarAposVencimento = false) { }
}

public class PagamentoCartao : Pagamento
{
    public PagamentoCartao(DateTime vencimento) : base(vencimento)
    {
        System.Console.WriteLine("Iniciando o Pagamento");
        DataPagamento = DateTime.Now;
    }

    // Sobrescrita de Método
    public override void Pagar(string numero)
    {
        System.Console.WriteLine("Pagar Cartão");
    }
}

public class Endereco
{
    string Cep;
}