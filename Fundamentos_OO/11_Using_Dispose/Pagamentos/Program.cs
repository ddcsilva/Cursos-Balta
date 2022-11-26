System.Console.WriteLine("Hello World!");

using (var pagamento = new Pagamento())
{
    System.Console.WriteLine("Processando o pagamento!");
}

public class Pagamento : IDisposable
{
    // Garbage Collection
    public Pagamento()
    {
        System.Console.WriteLine("Iniciando o Pagamento");
    }

    public void Dispose()
    {
        System.Console.WriteLine("Finalizando o Pagamento");
    }
}