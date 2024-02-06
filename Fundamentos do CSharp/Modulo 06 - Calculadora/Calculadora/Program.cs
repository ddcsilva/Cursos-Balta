Menu();

/// <summary>
/// Exibe o menu principal.
/// </summary>
static void Menu()
{
    Console.Clear(); // Limpa a tela do console.

    Console.WriteLine("Escolha uma das opções abaixo: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("-----------------------------");

    if (short.TryParse(Console.ReadLine(), out short opcao)) // Tenta converter a entrada do usuário para um número.
    {
        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 0: Environment.Exit(0); break; // Encerra a aplicação.
            default: Menu(); break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Por favor, insira um número válido.");
        Menu();
    }
}

/// <summary>
/// Realiza a soma de dois números.
/// </summary>
static void Soma()
{
    float primeiroValor = LerValor("Primeiro Valor: ");
    float segundoValor = LerValor("Segundo Valor: ");

    Console.WriteLine("");

    float resultado = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para continuar.

    Menu();
}

/// <summary>
/// Realiza a subtração de dois números.
/// </summary>
static void Subtracao()
{
    float primeiroValor = LerValor("Primeiro Valor: ");
    float segundoValor = LerValor("Segundo Valor: ");

    Console.WriteLine("");

    float resultado = primeiroValor - segundoValor;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para continuar.

    Menu();
}

/// <summary>
/// Realiza a divisão de dois números.
/// </summary>
static void Divisao()
{
    float primeiroValor = LerValor("Primeiro Valor: ");
    float segundoValor = LerValor("Segundo Valor: ");

    Console.WriteLine("");

    float resultado = primeiroValor / segundoValor;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para continuar.

    Menu();
}

/// <summary>
/// Realiza a multiplicação de dois números.
/// </summary>
static void Multiplicacao()
{
    float primeiroValor = LerValor("Primeiro Valor: ");
    float segundoValor = LerValor("Segundo Valor: ");

    Console.WriteLine("");

    float resultado = primeiroValor * segundoValor;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para continuar.

    Menu();
}

/// <summary>
/// Lê um valor do usuário e valida se é um número válido.
/// </summary>
/// <param name="mensagem">Mensagem a ser exibida para o usuário.</param>
/// <returns>Valor digitado pelo usuário.</returns>
static float LerValor(string mensagem)
{
    while (true)
    {
        Console.WriteLine(mensagem);
        string? entradaUsuario = Console.ReadLine(); // Lê a entrada do usuário.

        // Verifica se a entrada do usuário não é nula ou vazia e se é um número válido.
        if (!string.IsNullOrEmpty(entradaUsuario) && float.TryParse(entradaUsuario, out float valor))
        {
            return valor;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
    }
}