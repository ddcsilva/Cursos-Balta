System.Console.WriteLine("Hello World!");
Pagamento.Vencimento = DateTime.Now;

public static class Pagamento
{
    public static DateTime Vencimento { get; set; }
}

public static class Configuracoes
{
    public static string API_URL { get; set; }
}