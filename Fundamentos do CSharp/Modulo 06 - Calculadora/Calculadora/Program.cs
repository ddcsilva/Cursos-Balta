Console.Clear();

// Soma();
Subtracao();

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
}