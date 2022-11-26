Console.WriteLine("Hello, World!");
var pagamento = new Pagamento();

public class Pagamento
{
    DateTime Vencimento;
    Endereco enderecoPagamento;

    void Pagar() { }
}

public class Endereco
{
    string Cep;
}