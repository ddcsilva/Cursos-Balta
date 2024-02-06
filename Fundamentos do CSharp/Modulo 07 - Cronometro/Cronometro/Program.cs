Iniciar();

/// <summary>
/// Inicia a contagem de tempo
/// </summary>
static void Iniciar()
{
    int tempo = 10;
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear(); // Limpa a tela

        tempoAtual++;
        Console.WriteLine("Tempo atual: " + tempoAtual);

        Thread.Sleep(1000); // Aguarda 1 segundo
    }
}