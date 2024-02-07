Menu();

/// <summary>
/// Mostra o menu.
/// </summary>
static void Menu()
{
    Console.Clear();

    Console.WriteLine("S - Segundo (Exemplo: 10s)");
    Console.WriteLine("M - Minuto (Exemplo: 1m)");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");

    string opcao = Console.ReadLine()?.ToLower() ?? string.Empty;

    if (opcao == "0")
    {
        Environment.Exit(0); // Fecha a aplicação
    }

    if (opcao.Length < 2)
    {
        Console.WriteLine("Formato inválido, tente novamente.");
        Thread.Sleep(2000);
        Menu();
        return;
    }

    char tipo = opcao[opcao.Length - 1]; // Pega o último caractere
    int tempo;

    if (tipo != 's' && tipo != 'm') // Verifica se o último caractere é 's' ou 'm'
    {
        Console.WriteLine("Formato inválido, tente novamente.");
        Thread.Sleep(2000);
        Menu();
        return;
    }

    if (!int.TryParse(opcao.Substring(0, opcao.Length - 1), out tempo)) // Tenta converter todos os caracteres, menos o último
    {
        Console.WriteLine("Formato inválido, tente novamente.");
        Thread.Sleep(2000);
        Menu();
        return;
    }

    int multiplicador = tipo == 'm' ? 60 : 1; // Multiplica por 60 se for minuto

    PreContador(tempo * multiplicador);
}

/// <summary>
/// Prepara o contador.
/// </summary>
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
    Menu();
}