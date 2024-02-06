Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha uma das opções abaixo: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("-----------------------------");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.WriteLine("Primeiro Valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();

    Menu();
}

static void Subtracao()
{
    Console.WriteLine("Primeiro Valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor - segundoValor;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();

    Menu();
}

static void Divisao()
{
    Console.WriteLine("Primeiro Valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor / segundoValor;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey();

    Menu();
}

static void Multiplicacao()
{
    Console.WriteLine("Primeiro Valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor * segundoValor;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();

    Menu();
}