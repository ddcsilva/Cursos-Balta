Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("S - Segundo (Exemplo: 10s)");
    Console.WriteLine("M - Minuto (Exemplo: 1m)");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");

    string opcao = Console.ReadLine().ToLower();
    char tipo = char.Parse(opcao.Substring(opcao.Length - 1, 1)); // Pega o último caractere
    int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1)); // Pega todos os caracteres, menos o último
    int multiplicador = 1; // Por padrão, é segundo

    if (tipo == 'm')
        multiplicador = 60; // Se for minuto, multiplica por 60

    if (tempo == 0)
        Environment.Exit(0); // Fecha a aplicação

    PreContador(tempo * multiplicador);
}

static void PreContador(int tempo)
{
    Console.Clear();
    Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    Console.WriteLine("Vai!");
    Thread.Sleep(1000);

    IniciarContador(tempo);
}

/// <summary>
/// Inicia um contador.
/// </summary>
static void IniciarContador(int tempo)
{
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear();

        tempoAtual++;
        Console.WriteLine(tempoAtual);

        Thread.Sleep(1000); // Aguarda 1 segundo
    }

    Console.Clear();
    Console.WriteLine("Contador finalizado!");
    Thread.Sleep(2000); // Aguarda 2 segundos
}